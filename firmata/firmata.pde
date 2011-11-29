/*
 Copyright (C) 2006-2008 Hans-Christoph Steiner.  All rights reserved.

 This library is free software; you can redistribute it and/or
 modify it under the terms of the GNU Lesser General Public
 License as published by the Free Software Foundation; either
 version 2.1 of the License, or (at your option) any later version.

 See file LICENSE.txt for further informations on licensing terms.

 formatted using the GNU C formatting and indenting
*/

/*
 * TODO: use Program Control to load stored profiles from EEPROM
 */

/* CQ 11/2011
 * adding pwm management (direct copy paste from adafruit lib)
 *
 * CQ 04/2011
 * adding shift register support to handle AF motorshield
 * quick and dirty: rewrite this stuff...
 */

#include <Servo.h>
#include <Firmata.h>

/*==============================================================================
 * GLOBAL VARIABLES
 *============================================================================*/

/* has the command arrived? */
boolean firstCommand = false;
int dataOnSerial = 0;
boolean statusLed = false;

/* analog inputs */
int analogInputsToReport = 0; // bitwise array to store pin reporting

/* digital input ports */
byte reportPINs[TOTAL_PORTS];       // 1 = report this port, 0 = silence
byte previousPINs[TOTAL_PORTS];     // previous 8 bits sent

/* pins configuration */
byte pinConfig[TOTAL_PINS];         // configuration of every pin
byte portConfigInputs[TOTAL_PORTS]; // each bit: 1 = pin in INPUT, 0 = anything else
int pinState[TOTAL_PINS];           // any value that has been written

/* timer variables */
unsigned long currentMillis;        // store the current value from millis()
unsigned long previousMillis;       // for comparison with currentMillis
int samplingInterval = 19;          // how often to run the main loop (in ms)
unsigned long toggleMillis;

Servo servos[MAX_SERVOS];

/* shift register related stuff */
/* TODO:
 * - implement run & setSpeed on the PC side
 *   => check AFMotor.cpp/.h
 * - remember which motor is where
 *   => use this information
 *  (order of bits in the shift reg)
 *      #define MOTOR1_A 2
 *      #define MOTOR1_B 3
 *      #define MOTOR2_A 1
 *      #define MOTOR2_B 4
 *      #define MOTOR4_A 0
 *      #define MOTOR4_B 6
 *      #define MOTOR3_A 5
 *      #define MOTOR3_B 7
 * - add capabilities on related pins ?
 * - reserve pins used for the shift register & pwm:
 *   => cf #defines below
 *   => cf PWM info below
 * - Check these info:
 *   => PWM1 is on arduino (uno) pin #11
 *   => PWM2 is on arduino (uno) pin #3
 *   => PWM3 is on arduino (uno) pin #6
 *   => PWM4 is on arduino (uno) pin #5
 * - send data on a sysex request, ID: SHIFT_DATA 0x75
 *   => use first version of the firmata proposal
 */
 #define PWM1 11
 #define PWM2 3
 #define PWM3 6
 #define PWM4 5

 #define MOTOR1_A 2
 #define MOTOR1_B 3
 #define MOTOR2_A 1
 #define MOTOR2_B 4
 #define MOTOR4_A 0
 #define MOTOR4_B 6
 #define MOTOR3_A 5
 #define MOTOR3_B 7
 
//TODO: should be configured instead of hardcoded
#define MOTORLATCH 12
#define MOTORCLK 4
#define MOTORENABLE 7
#define MOTORDATA 8

#define FORWARD 1
#define BACKWARD 2
#define RELEASE 3

#define MOTOR12_64KHZ _BV(CS20)  // no prescale
#define MOTOR12_8KHZ _BV(CS21)   // divide by 8
#define MOTOR12_2KHZ _BV(CS21) | _BV(CS20) // divide by 32
#define MOTOR12_1KHZ _BV(CS22)  // divide by 64

#define MOTOR34_64KHZ _BV(CS00)  // no prescale
#define MOTOR34_8KHZ _BV(CS01)   // divide by 8
#define MOTOR34_1KHZ _BV(CS01) | _BV(CS00)  // divide by 64

//TODO: #define SHIFTREG as a pinmode possibility => nope, it already exists as 'SHIFT' (should be thought about, tho).

void shiftRegister_enable(void);
void shiftRegister_tx(void);

static uint8_t latch_state;

/*==============================================================================
 * FUNCTIONS
 *============================================================================*/
inline void initPWM1(uint8_t freq) {
    // use PWM from timer2A on PB3 (Arduino pin #11)
    TCCR2A |= _BV(COM2A1) | _BV(WGM20) | _BV(WGM21); // fast PWM, turn on oc2a
    TCCR2B = freq & 0x7;
    OCR2A = 0;
    pinMode(11, OUTPUT);
}

inline void setPWM1(uint8_t s) {
    // use PWM from timer2A on PB3 (Arduino pin #11)
    OCR2A = s;
}

inline void initPWM2(uint8_t freq) {
    // use PWM from timer2B (pin 3)
    TCCR2A |= _BV(COM2B1) | _BV(WGM20) | _BV(WGM21); // fast PWM, turn on oc2b
    TCCR2B = freq & 0x7;
    OCR2B = 0;
    pinMode(3, OUTPUT);
}

inline void setPWM2(uint8_t s) {
    // use PWM from timer2A on PB3 (Arduino pin #11)
    OCR2B = s;
}

inline void initPWM3(uint8_t freq) {
    // use PWM from timer0A / PD6 (pin 6)
    TCCR0A |= _BV(COM0A1) | _BV(WGM00) | _BV(WGM01); // fast PWM, turn on OC0A
    //TCCR0B = freq & 0x7;
    OCR0A = 0;
    pinMode(6, OUTPUT);
}

inline void setPWM3(uint8_t s) {
    // use PWM from timer0A on PB3 (Arduino pin #6)
    OCR0A = s;
}

inline void initPWM4(uint8_t freq) {
    // use PWM from timer0B / PD5 (pin 5)
    TCCR0A |= _BV(COM0B1) | _BV(WGM00) | _BV(WGM01); // fast PWM, turn on oc0a
    //TCCR0B = freq & 0x7;
    OCR0B = 0;
    pinMode(5, OUTPUT);
}

inline void setPWM4(uint8_t s) {
    // use PWM from timer0A on PB3 (Arduino pin #6)
    OCR0B = s;
}

void toggleLed() 
{
  if (millis() - toggleMillis > 500) {
    statusLed = !statusLed;
    digitalWrite(13, statusLed);
    toggleMillis = millis();
  }
}

void motorRun(uint8_t motornum, uint8_t cmd, uint8_t pwmSpeed) {
  uint8_t a, b;
  switch (motornum) {
    case 1:
      a = MOTOR1_A; b = MOTOR1_B;setPWM1(pwmSpeed);break;
    case 2:
      a = MOTOR2_A; b = MOTOR2_B;setPWM2(pwmSpeed);break;
    case 3:
      a = MOTOR3_A; b = MOTOR3_B;setPWM3(pwmSpeed);break;
    case 4:
      a = MOTOR4_A; b = MOTOR4_B;setPWM4(pwmSpeed);break;
    default:
      return;
  }
  
  switch (cmd) {
    case FORWARD:
      latch_state |= _BV(a);
      latch_state &= ~_BV(b); 
      shiftRegister_tx();
      break;
    case BACKWARD:
      latch_state &= ~_BV(a);
      latch_state |= _BV(b); 
      shiftRegister_tx();
      break;
    case RELEASE:
      latch_state &= ~_BV(a);
      latch_state &= ~_BV(b); 
      shiftRegister_tx();
      break;
  }



}
  
//TODO: rewrite this completely
void shiftRegister_enable() {
 // setup the latch
 pinMode(MOTORLATCH, OUTPUT);
 pinMode(MOTORENABLE, OUTPUT);
 pinMode(MOTORDATA, OUTPUT);
 pinMode(MOTORCLK, OUTPUT);

 latch_state = 0;

 shiftRegister_tx();  // "reset"

 //ENABLE_PORT &= ~_BV(ENABLE); // enable the chip outputs!
 digitalWrite(MOTORENABLE, LOW);
 
 initPWM1(MOTOR12_64KHZ);
 initPWM2(MOTOR12_64KHZ);
 initPWM3(MOTOR34_64KHZ);
 initPWM4(MOTOR34_64KHZ);
}


//use this function to send shift reg data
void shiftRegister_tx(void) {
  uint8_t i;

  //LATCH_PORT &= ~_BV(LATCH);
  digitalWrite(MOTORLATCH, LOW);

  //SER_PORT &= ~_BV(SER);
  digitalWrite(MOTORDATA, LOW);

  for (i=0; i<8; i++) {
    //CLK_PORT &= ~_BV(CLK);
    digitalWrite(MOTORCLK, LOW);

    if (latch_state & _BV(7-i)) {
      //SER_PORT |= _BV(SER);
      digitalWrite(MOTORDATA, HIGH);
    } else {
      //SER_PORT &= ~_BV(SER);
      digitalWrite(MOTORDATA, LOW);
    }
    //CLK_PORT |= _BV(CLK);
    digitalWrite(MOTORCLK, HIGH);
  }
  //LATCH_PORT |= _BV(LATCH);
  digitalWrite(MOTORLATCH, HIGH);
  
  //PWM 100%
//  digitalWrite(PWM1, HIGH);
//  digitalWrite(PWM2, HIGH);
//  digitalWrite(PWM3, HIGH);
//  digitalWrite(PWM4, HIGH);
}


void outputPort(byte portNumber, byte portValue, byte forceSend)
{
  // pins not configured as INPUT are cleared to zeros
  portValue = portValue & portConfigInputs[portNumber];
  // only send if the value is different than previously sent
  if(forceSend || previousPINs[portNumber] != portValue) {
    Firmata.sendDigitalPort(portNumber, portValue);
    previousPINs[portNumber] = portValue;
  }
}

/* -----------------------------------------------------------------------------
 * check all the active digital inputs for change of state, then add any events
 * to the Serial output queue using Serial.print() */
void checkDigitalInputs(void)
{
  /* Using non-looping code allows constants to be given to readPort().
   * The compiler will apply substantial optimizations if the inputs
   * to readPort() are compile-time constants. */
  if (TOTAL_PORTS > 0 && reportPINs[0]) outputPort(0, readPort(0, portConfigInputs[0]), false);
  if (TOTAL_PORTS > 1 && reportPINs[1]) outputPort(1, readPort(1, portConfigInputs[1]), false);
  if (TOTAL_PORTS > 2 && reportPINs[2]) outputPort(2, readPort(2, portConfigInputs[2]), false);
  if (TOTAL_PORTS > 3 && reportPINs[3]) outputPort(3, readPort(3, portConfigInputs[3]), false);
  if (TOTAL_PORTS > 4 && reportPINs[4]) outputPort(4, readPort(4, portConfigInputs[4]), false);
  if (TOTAL_PORTS > 5 && reportPINs[5]) outputPort(5, readPort(5, portConfigInputs[5]), false);
  if (TOTAL_PORTS > 6 && reportPINs[6]) outputPort(6, readPort(6, portConfigInputs[6]), false);
  if (TOTAL_PORTS > 7 && reportPINs[7]) outputPort(7, readPort(7, portConfigInputs[7]), false);
  if (TOTAL_PORTS > 8 && reportPINs[8]) outputPort(8, readPort(8, portConfigInputs[8]), false);
  if (TOTAL_PORTS > 9 && reportPINs[9]) outputPort(9, readPort(9, portConfigInputs[9]), false);
  if (TOTAL_PORTS > 10 && reportPINs[10]) outputPort(10, readPort(10, portConfigInputs[10]), false);
  if (TOTAL_PORTS > 11 && reportPINs[11]) outputPort(11, readPort(11, portConfigInputs[11]), false);
  if (TOTAL_PORTS > 12 && reportPINs[12]) outputPort(12, readPort(12, portConfigInputs[12]), false);
  if (TOTAL_PORTS > 13 && reportPINs[13]) outputPort(13, readPort(13, portConfigInputs[13]), false);
  if (TOTAL_PORTS > 14 && reportPINs[14]) outputPort(14, readPort(14, portConfigInputs[14]), false);
  if (TOTAL_PORTS > 15 && reportPINs[15]) outputPort(15, readPort(15, portConfigInputs[15]), false);
}

// -----------------------------------------------------------------------------
/* sets the pin mode to the correct state and sets the relevant bits in the
 * two bit-arrays that track Digital I/O and PWM status
 */
void setPinModeCallback(byte pin, int mode)
{
 if (IS_PIN_SERVO(pin) && mode != SERVO && servos[PIN_TO_SERVO(pin)].attached()) {
   servos[PIN_TO_SERVO(pin)].detach();
 }
 if (IS_PIN_ANALOG(pin)) {
   reportAnalogCallback(PIN_TO_ANALOG(pin), mode == ANALOG ? 1 : 0);
// turn on/off reporting
 }
 if (IS_PIN_DIGITAL(pin)) {
   if (mode == INPUT) {
     portConfigInputs[pin/8] |= (1 << (pin & 7));
   } else {
     portConfigInputs[pin/8] &= ~(1 << (pin & 7));
   }
 }
 pinState[pin] = 0;
 switch(mode) {
 case ANALOG:
   if (IS_PIN_ANALOG(pin)) {
     if (IS_PIN_DIGITAL(pin)) {
       pinMode(PIN_TO_DIGITAL(pin), INPUT); // disable output driver
       digitalWrite(PIN_TO_DIGITAL(pin), LOW); // disable internal pull-ups
     }
     pinConfig[pin] = ANALOG;
   }
   break;
 case INPUT:
   if (IS_PIN_DIGITAL(pin)) {
     pinMode(PIN_TO_DIGITAL(pin), INPUT); // disable output driver
     digitalWrite(PIN_TO_DIGITAL(pin), LOW); // disable internal pull-ups
     pinConfig[pin] = INPUT;
   }
   break;
 case OUTPUT:
   if (IS_PIN_DIGITAL(pin)) {
     digitalWrite(PIN_TO_DIGITAL(pin), LOW); // disable PWM
     pinMode(PIN_TO_DIGITAL(pin), OUTPUT);
     pinConfig[pin] = OUTPUT;
   }
   break;
 case PWM:
   if (IS_PIN_PWM(pin)) {
     pinMode(PIN_TO_PWM(pin), OUTPUT);
     analogWrite(PIN_TO_PWM(pin), 0);
     pinConfig[pin] = PWM;
   }
   break;
 case SERVO:
   if (IS_PIN_SERVO(pin)) {
     pinConfig[pin] = SERVO;
     if (!servos[PIN_TO_SERVO(pin)].attached()) {
         servos[PIN_TO_SERVO(pin)].attach(PIN_TO_DIGITAL(pin));
     } else {
         Firmata.sendString("Servo only on pins from 2 to 13");
     }
   }
   break;
 case I2C:
   pinConfig[pin] = mode;
   Firmata.sendString("I2C mode not yet supported");
   break;
 case SHIFT:
   pinConfig[pin] = SHIFT;
   //TODO: add shift register reset here (eg latch_state =0;) ? 
   Firmata.sendString("prototype shift register support");
   break;

 default:
   Firmata.sendString("Unknown pin mode"); // TODO: put error msgs in EEPROM
 }
 // TODO: save status to EEPROM here, if changed
}

void analogWriteCallback(byte pin, int value)
{
 if (pin < TOTAL_PINS) {
   switch(pinConfig[pin]) {
   case SERVO:
     if (IS_PIN_SERVO(pin))
       servos[PIN_TO_SERVO(pin)].write(value);
       pinState[pin] = value;
     break;
   case PWM:
     if (IS_PIN_PWM(pin))
       analogWrite(PIN_TO_PWM(pin), value);
       pinState[pin] = value;
     break;
   }
 }
}

void digitalWriteCallback(byte port, int value)
{
 byte pin, lastPin, mask=1, pinWriteMask=0;

 if (port < TOTAL_PORTS) {
   // create a mask of the pins on this port that are writable.
   lastPin = port*8+8;
   if (lastPin > TOTAL_PINS) lastPin = TOTAL_PINS;
   for (pin=port*8; pin < lastPin; pin++) {
     // do not disturb non-digital pins (eg, Rx & Tx)
     if (IS_PIN_DIGITAL(pin)) {
       // only write to OUTPUT and INPUT (enables pullup)
       // do not touch pins in PWM, ANALOG, SERVO or other modes
       if (pinConfig[pin] == OUTPUT || pinConfig[pin] == INPUT) {
         pinWriteMask |= mask;
         pinState[pin] = ((byte)value & mask) ? 1 : 0;
       }
     }
     mask = mask << 1;
   }
   writePort(port, (byte)value, pinWriteMask);
 }
}


// -----------------------------------------------------------------------------
/* sets bits in a bit array (int) to toggle the reporting of the analogIns
 */
//void FirmataClass::setAnalogPinReporting(byte pin, byte state) {
//}
void reportAnalogCallback(byte analogPin, int value)
{
 if (analogPin < TOTAL_ANALOG_PINS) {
   if(value == 0) {
     analogInputsToReport = analogInputsToReport &~ (1 << analogPin);
   } else {
     analogInputsToReport = analogInputsToReport | (1 << analogPin);
   }
 }
 // TODO: save status to EEPROM here, if changed
}

void reportDigitalCallback(byte port, int value)
{
 if (port < TOTAL_PORTS) {
   reportPINs[port] = (byte)value;
 }
 // do not disable analog reporting on these 8 pins, to allow some
 // pins used for digital, others analog.  Instead, allow both types
 // of reporting to be enabled, but check if the pin is configured
 // as analog when sampling the analog inputs.  Likewise, while
 // scanning digital pins, portConfigInputs will mask off values from any
 // pins configured as analog
}

/*==============================================================================
 * SYSEX-BASED commands
 *============================================================================*/

void sysexCallback(byte command, byte argc, byte *argv)
{
 switch(command) {
 case SERVO_CONFIG:
   if(argc > 4) {
     // these vars are here for clarity, they'll optimized away by the compiler
     byte pin = argv[0];
     int minPulse = argv[1] + (argv[2] << 7);
     int maxPulse = argv[3] + (argv[4] << 7);

     if (IS_PIN_SERVO(pin)) {
       // servos are pins from 2 to 13, so offset for array
       if (servos[PIN_TO_SERVO(pin)].attached())
         servos[PIN_TO_SERVO(pin)].detach();
       servos[PIN_TO_SERVO(pin)].attach(PIN_TO_DIGITAL(pin), minPulse, maxPulse);
       setPinModeCallback(pin, SERVO);
     }
   }
   break;
 case SAMPLING_INTERVAL:
   if (argc > 1)
     samplingInterval = argv[0] + (argv[1] << 7);
   else
     Firmata.sendString("Not enough data");
   break;
 case EXTENDED_ANALOG:
   if (argc > 1) {
     int val = argv[1];
     if (argc > 2) val |= (argv[2] << 7);
     if (argc > 3) val |= (argv[3] << 14);
     analogWriteCallback(argv[0], val);
   }
   break;
 case CAPABILITY_QUERY:
   Serial.write(START_SYSEX);
   Serial.write(CAPABILITY_RESPONSE);
   for (byte pin=0; pin < TOTAL_PINS; pin++) {
     if (IS_PIN_DIGITAL(pin)) {
       Serial.write((byte)INPUT);
       Serial.write(1);
       Serial.write((byte)OUTPUT);
       Serial.write(1);
     }
     if (IS_PIN_ANALOG(pin)) {
       Serial.write(ANALOG);
       Serial.write(10);
     }
     if (IS_PIN_PWM(pin)) {
       Serial.write(PWM);
       Serial.write(8);
     }
     if (IS_PIN_SERVO(pin)) {
       Serial.write(SERVO);
       Serial.write(14);
     }
     Serial.write(127);
   }
   Serial.write(END_SYSEX);
   break;
 case PIN_STATE_QUERY:
   if (argc > 0) {
     byte pin=argv[0];
     Serial.write(START_SYSEX);
     Serial.write(PIN_STATE_RESPONSE);
     Serial.write(pin);
     if (pin < TOTAL_PINS) {
       Serial.write((byte)pinConfig[pin]);
       Serial.write((byte)pinState[pin] & 0x7F);
       if (pinState[pin] & 0xFF80) Serial.write((byte)(pinState[pin] >> 7) & 0x7F);
       if (pinState[pin] & 0xC000) Serial.write((byte)(pinState[pin] >> 14) & 0x7F);
     }
     Serial.write(END_SYSEX);
   }
   break;
 case ANALOG_MAPPING_QUERY:
   Serial.write(START_SYSEX);
   Serial.write(ANALOG_MAPPING_RESPONSE);
   for (byte pin=0; pin < TOTAL_PINS; pin++) {
     Serial.write(IS_PIN_ANALOG(pin) ? PIN_TO_ANALOG(pin) : 127);
   }
   Serial.write(END_SYSEX);
   break;
 case SHIFT_DATA://copy paste from servo config
     Serial.write(START_SYSEX);
     Serial.write(SHIFT_DATA);
     shiftRegister_enable();  //shouldnt do that this way (inefficient), but...
     
     //latch_state = 0x00;//clear old state
     
     //argv[0] byte 2 de la desc : datapin
     //argv[1] byte 3 de la desc : clockpin
     //argv[2] byte 4 de la desc : latchpin
     //argv[3] byte 5 de la desc : msbfirst (boolean)
     //argv[4] byte 6 de la desc : bits 0-6
     //argv[5] byte 7 de la desc : bit 7
     
     //latch_state |= (argv[4]&0x7F);//grab new data: bits 0-6 at pos 0..6
     //latch_state |= (((argv[5]&0x7F)<<7) & 0x80);//grab new data: bit 7 is at pos 0
     //shiftRegister_tx();//output that data
     //no output on serial
     
     motorRun(argv[0], argv[1], argv[2]);
     
     Serial.write(END_SYSEX);
   break;

 }
}


/*==============================================================================
 * SETUP()
 *============================================================================*/
void setup()
{
 byte i;

 Firmata.setFirmwareVersion(2, 3);

 Firmata.attach(ANALOG_MESSAGE, analogWriteCallback);
 Firmata.attach(DIGITAL_MESSAGE, digitalWriteCallback);
 Firmata.attach(REPORT_ANALOG, reportAnalogCallback);
 Firmata.attach(REPORT_DIGITAL, reportDigitalCallback);
 Firmata.attach(SET_PIN_MODE, setPinModeCallback);
 Firmata.attach(START_SYSEX, sysexCallback);

 // TODO: load state from EEPROM here

 /* these are initialized to zero by the compiler startup code
 for (i=0; i < TOTAL_PORTS; i++) {
   reportPINs[i] = false;
   portConfigInputs[i] = 0;
   previousPINs[i] = 0;
 }
 */
 for (i=0; i < TOTAL_PINS; i++) {
   if (IS_PIN_ANALOG(i)) {
     // turns off pullup, configures everything
     setPinModeCallback(i, ANALOG);
   } else {
     // sets the output to 0, configures portConfigInputs
     setPinModeCallback(i, OUTPUT);
   }
 }
 // by defult, do not report any analog inputs
 analogInputsToReport = 0;

 Firmata.begin(57600);

 /* send digital inputs to set the initial state on the host computer,
  * since once in the loop(), this firmware will only send on change */
 for (i=0; i < TOTAL_PORTS; i++) {
   outputPort(i, readPort(i, portConfigInputs[i]), true);
 }
  
  /* init the toggleLed counter */
  toggleMillis = millis();
  pinMode(13, OUTPUT);
}

/*==============================================================================
 * LOOP()
 *============================================================================*/
void loop()
{
 byte pin, analogPin;

 /* DIGITALREAD - as fast as possible, check for changes and output them to the
  * FTDI buffer using Serial.print()  */
  checkDigitalInputs();  

  //XXX: hack Firmata to blink until serial command arrives 
  dataOnSerial = Firmata.available();
  if (dataOnSerial > 0 && !firstCommand) {
    firstCommand = true;
  }
  //XXX: do the blink if the first command hasn't arrived yet
  //     configures pin 13 as output and then back as input
  if (!firstCommand) {
    toggleLed();
  }

 /* SERIALREAD - processing incoming messagse as soon as possible, while still
  * checking digital inputs.  */
  while(dataOnSerial) {
   Firmata.processInput();
    dataOnSerial = Firmata.available();
  }

 /* SEND FTDI WRITE BUFFER - make sure that the FTDI buffer doesn't go over
  * 60 bytes. use a timer to sending an event character every 4 ms to
  * trigger the buffer to dump. */

 currentMillis = millis();
 if (currentMillis - previousMillis > samplingInterval) {
   previousMillis += samplingInterval;
   /* ANALOGREAD - do all analogReads() at the configured sampling interval */
   for(pin=0; pin<TOTAL_PINS; pin++) {
     if (IS_PIN_ANALOG(pin) && pinConfig[pin] == ANALOG) {
       analogPin = PIN_TO_ANALOG(pin);
       if (analogInputsToReport & (1 << analogPin)) {
         Firmata.sendAnalog(analogPin, analogRead(analogPin));
       }
     }
   }
 }
}

