'From etoys4.0 of 9 October 2008 [latest update: #2340] on 19 December 2010 at 10:04:23 pm'!
Object subclass: #ArduinoSketchUploader
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-Uploading'!

Object subclass: #ArduinoType
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!

ArduinoType subclass: #ArduinoATmega168
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoATmega328
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoATmega8
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoBT
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoDiecimila
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoLilyPad
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoLilyPad328
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoMega
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoMini
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoPro
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoPro328
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
ArduinoType subclass: #ArduinoUno328
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-BoardTypes'!
Error subclass: #CompilingSketchError
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-Uploading'!
Error subclass: #UploadingSketchError
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Compiler-Uploading'!


!ArduinoSketchUploader methodsFor: 'compiling and uploading'!
checkForErrorsOn: t1 
	| t2 t3 |
	t2 := FileStream
				fileNamed: (t1 fullPathFor: 'finished').
	t3 := t2 contents.
	t2 close.
	t3 asNumber = 1
		ifTrue: [^ CompilingSketchError signal]! !

!ArduinoSketchUploader methodsFor: 'compiling and uploading'!
uploadFirmataOnPort: t1 arduinoType: t2 
	self
		uploadSketchNamed: 'StandardFirmata'
		onPort: t1
		arduinoType: t2! !

!ArduinoSketchUploader methodsFor: 'compiling and uploading'!
uploadSketchNamed: t1 onPort: t2 arduinoType: t3 
	self
		uploadSketchNamed: t1
		onPort: t2
		uploadRate: t3 uploadRate
		mcu: t3 mcu
		fCpu: t3 fCpu
		avrdudeProgrammer: t3 avrdudeProgrammer! !

!ArduinoSketchUploader methodsFor: 'compiling and uploading'!
uploadSketchNamed: t1 onPort: t2 uploadRate: t3 mcu: t4 fCpu: t5 avrdudeProgrammer: t6 
	| t7 |
	t7 := self sketchesDirectory directoryNamed: t1.
	(self hasMakefile: t7)
		ifFalse: [^ self error: 'No Makefile'].
	self
		waitFor: self timeoutSeconds
		untilFinish: [self
				executeUploadFor: t1
				onPort: t2
				uploadRate: t3
				mcu: t4
				fCpu: t5
				avrdudeProgrammer: t6]
		on: t7! !

!ArduinoSketchUploader methodsFor: 'compiling and uploading'!
uploadSketch: t1 onPort: t2 arduinoType: t3 
	self createSketchDirectoryNamed: t1 name.
	self createMakefileOnDirectoryNamed: t1 name.
	self
		createSourceFile: (ArduinoCTranslator new translateSketch: t1)
		onDirectoryNamed: t1 name.
	self
		uploadSketchNamed: t1 name
		onPort: t2
		uploadRate: t3 uploadRate
		mcu: t3 mcu
		fCpu: t3 fCpu
		avrdudeProgrammer: t3 avrdudeProgrammer! !

!ArduinoSketchUploader methodsFor: 'compiling and uploading'!
waitFor: t1 untilFinish: t2 on: t3 
	| t4 t5 |
	t5 := t1.
	t3
		deleteFileNamed: 'finished'
		ifAbsent: [].
	t2 value.
	t4 := Delay forSeconds: 1.
	[t4 wait.
	t5 := t5 - 1]
		doWhileFalse: [t5 = 0
				or: [t3 fileExists: 'finished']].
	t5 = 0
		ifTrue: [^ UploadingSketchError signal].
	self checkForErrorsOn: t3! !

!ArduinoSketchUploader methodsFor: 'directory'!
createMakefileOnDirectoryNamed: t1 
	| t2 |
	t2 := FileStream forceNewFileNamed: self sketchesDirectory pathName , '\' , t1 , '\Makefile'.
	t2 nextPutAll: self class makefile.
	t2 close! !

!ArduinoSketchUploader methodsFor: 'directory'!
createSketchDirectoryNamed: t1 
	(self sketchesDirectory directoryExists: t1)
		ifFalse: [self sketchesDirectory createDirectory: t1]! !

!ArduinoSketchUploader methodsFor: 'directory'!
createSourceFileOnDirectoryNamed: t1 
	| t2 |
	t2 := FileStream forceNewFileNamed: self sketchesDirectory pathName , '\' , t1 , '\' , t1 , '.pde'.
	t2 nextPutAll: self class makefile.
	t2 close! !

!ArduinoSketchUploader methodsFor: 'directory'!
createSourceFile: t1 onDirectoryNamed: t2 
	| t3 |
	t3 := FileStream forceNewFileNamed: self sketchesDirectory pathName , '\' , t2 , '\' , t2 , '.pde'.
	t3 nextPutAll: t1.
	t3 close! !

!ArduinoSketchUploader methodsFor: 'private'!
executeInUnixUploadFor: t1 onPort: t2 uploadRate: t3 mcu: t4 fCpu: t5 avrdudeProgrammer: t6 
	(Smalltalk
		at: #OSProcess
		ifAbsent: [^ self error: 'OSProcess not installed']) thisOSProcess chDir: 'Arduino/Sketches';
		 command: './upload.sh ' , t1 , ' ' , t2 , ' ' , t3 asString , ' ' , t4 , ' ' , t5 asString , ' ' , t6! !

!ArduinoSketchUploader methodsFor: 'private'!
executeInWin32UploadFor: t1 onPort: t2 uploadRate: t3 mcu: t4 fCpu: t5 avrdudeProgrammer: t6 
	((Smalltalk
			at: #Win32Shell
			ifAbsent: [^ self error: 'FFI not installed']) new
			shellExecute: nil
			lpOperation: 'open'
			lpFile: 'upload.bat'
			lpParameters: t1 , ' ' , t2 , ' ' , t3 asString , ' ' , t4 , ' ' , t5 asString , ' ' , t6
			lpDirectory: 'Arduino/Sketches'
			nShowCmd: 0)
			<= 32
		ifTrue: [self error: 'System error']! !

!ArduinoSketchUploader methodsFor: 'private'!
executeUploadFor: t1 onPort: t2 uploadRate: t3 mcu: t4 fCpu: t5 avrdudeProgrammer: t6 
	Smalltalk platformName = 'unix'
		ifTrue: [^ self
				executeInUnixUploadFor: t1
				onPort: t2
				uploadRate: t3
				mcu: t4
				fCpu: t5
				avrdudeProgrammer: t6].
	Smalltalk platformName = 'Win32'
		ifTrue: [^ self
				executeInWin32UploadFor: t1
				onPort: t2
				uploadRate: t3
				mcu: t4
				fCpu: t5
				avrdudeProgrammer: t6].
	^ self error: Smalltalk platformName , ' - Platform not supported'! !

!ArduinoSketchUploader methodsFor: 'testing'!
hasMakefile: t1 
	^ t1 fileExists: 'Makefile'! !

!ArduinoSketchUploader methodsFor: 'accessing'!
sketchesDirectory
	^ (FileDirectory default directoryNamed: 'Arduino')
		directoryNamed: 'Sketches'! !

!ArduinoSketchUploader methodsFor: 'accessing'!
timeoutSeconds
	^ 45! !


!ArduinoSketchUploader class methodsFor: 'as yet unclassified'!
makefile
	^ '# Arduino 0015 Makefile
# Arduino adaptation by mellis, eighthave, oli.keller
#
# This makefile allows you to build sketches from the command line
# without the Arduino environment (or Java).
#
# Detailed instructions for using the makefile:
#
#  1. Copy this file into the folder with your sketch. There should be a
#     file with the same name as the folder and with the extension .pde
#     (e.g. foo.pde in the foo/ folder).
#
#  2. Modify the line containg "INSTALL_DIR" to point to the directory that
#     contains the Arduino installation (for example, under Mac OS X, this
#     might be /Applications/arduino-0012).
#
#  3. Modify the line containing "PORT" to refer to the filename
#     representing the USB or serial connection to your Arduino board
#     (e.g. PORT = /dev/tty.USB0).  If the exact name of this file
#     changes, you can use * as a wildcard (e.g. PORT = /dev/tty.usb*).
#
#  4. Set the line containing "MCU" to match your board''s processor. 
#     Older one''s are atmega8 based, newer ones like Arduino Mini, Bluetooth
#     or Diecimila have the atmega168.  If you''re using a LilyPad Arduino,
#     change F_CPU to 8000000.
#
#  5. At the command line, change to the directory containing your
#     program''file and the makefile.
#
#  6. Type "make" and press enter to compile/verify your program.
#
#  7. Type "make upload", reset your Arduino board, and press enter to
#     upload your program to the Arduino board.
#
# $Id$

TARGET = Blink
INSTALL_DIR = ../..
PORT = com6
UPLOAD_RATE = 57600
AVRDUDE_PROGRAMMER = stk500
MCU = atmega328p
F_CPU = 16000000

############################################################################
# Below here nothing should be changed...

ARDUINO = $(INSTALL_DIR)/hardware/cores/arduino
AVR_TOOLS_PATH = $(INSTALL_DIR)/hardware/tools/avr/bin
SRC =  $(ARDUINO)/pins_arduino.c $(ARDUINO)/wiring.c \
$(ARDUINO)/wiring_analog.c $(ARDUINO)/wiring_digital.c \
$(ARDUINO)/wiring_pulse.c \
$(ARDUINO)/wiring_shift.c $(ARDUINO)/WInterrupts.c
CXXSRC = $(ARDUINO)/HardwareSerial.cpp $(ARDUINO)/WMath.cpp \
$(ARDUINO)/Print.cpp
FORMAT = ihex


# Name of this Makefile (used for "make depend").
MAKEFILE = Makefile

# Debugging format.
# Native formats for AVR-GCC''-g are stabs [default], or dwarf-2.
# AVR (extended) COFF requires stabs, plus an avr-objcopy run.
DEBUG = stabs

OPT = s

# Place -D or -U options here
CDEFS = -DF_CPU=$(F_CPU)
CXXDEFS = -DF_CPU=$(F_CPU)

# Place -I options here
CINCS = -I$(ARDUINO)
CXXINCS = -I$(ARDUINO)

# Compiler flag to set the C Standard level.
# c89   - "ANSI" C
# gnu89 - c89 plus GCC extensions
# c99   - ISO C99 standard (not yet fully implemented)
# gnu99 - c99 plus GCC extensions
CSTANDARD = -std=gnu99
CDEBUG = -g$(DEBUG)
CWARN = -Wall -Wstrict-prototypes
CTUNING = -funsigned-char -funsigned-bitfields -fpack-struct -fshort-enums
#CEXTRA = -Wa,-adhlns=$(<:.c=.lst)

CFLAGS = $(CDEBUG) $(CDEFS) $(CINCS) -O$(OPT) $(CWARN) $(CSTANDARD) $(CEXTRA)
CXXFLAGS = $(CDEFS) $(CINCS) -O$(OPT)
#ASFLAGS = -Wa,-adhlns=$(<:.S=.lst),-gstabs 
LDFLAGS = -lm


# Programming support using avrdude. Settings and variables.
AVRDUDE_PORT = $(PORT)
AVRDUDE_WRITE_FLASH = -U flash:w:applet/$(TARGET).hex
AVRDUDE_FLAGS = -V -F -C $(INSTALL_DIR)/hardware/tools/avr/etc/avrdude.conf \
-p $(MCU) -P $(AVRDUDE_PORT) -c $(AVRDUDE_PROGRAMMER) \
-b $(UPLOAD_RATE)

# Program settings
CC = $(AVR_TOOLS_PATH)/avr-gcc
CXX = $(AVR_TOOLS_PATH)/avr-g++
OBJCOPY = $(AVR_TOOLS_PATH)/avr-objcopy
OBJDUMP = $(AVR_TOOLS_PATH)/avr-objdump
AR  = $(AVR_TOOLS_PATH)/avr-ar
SIZE = $(AVR_TOOLS_PATH)/avr-size
NM = $(AVR_TOOLS_PATH)/avr-nm
AVRDUDE = $(AVR_TOOLS_PATH)/avrdude
REMOVE = rm -f
MV = mv -f

# Define all object files.
OBJ = $(SRC:.c=.o) $(CXXSRC:.cpp=.o) $(ASRC:.S=.o) 

# Define all listing files.
LST = $(ASRC:.S=.lst) $(CXXSRC:.cpp=.lst) $(SRC:.c=.lst)

# Combine all necessary flags and optional flags.
# Add target processor to flags.
ALL_CFLAGS = -mmcu=$(MCU) -I. $(CFLAGS)
ALL_CXXFLAGS = -mmcu=$(MCU) -I. $(CXXFLAGS)
ALL_ASFLAGS = -mmcu=$(MCU) -I. -x assembler-with-cpp $(ASFLAGS)


# Default target.
all: applet_files build sizeafter

build: elf hex 

applet_files: $(TARGET).pde
	# Here is the "preprocessing".
	# It creates a .cpp file based with the same name as the .pde file.
	# On top of the new .cpp file comes the WProgram.h header.
	# At the end there is a generic main() function attached.
	# Then the .cpp file will be compiled. Errors during compile will
	# refer to this new, automatically generated, file. 
	# Not the original .pde file you actually edit...
	test -d applet || mkdir applet
	echo ''#include "WProgram.h"''> applet/$(TARGET).cpp 
	cat $(TARGET).pde >> applet/$(TARGET).cpp
	cat $(ARDUINO)/main.cxx >> applet/$(TARGET).cpp

elf: applet/$(TARGET).elf
hex: applet/$(TARGET).hex
eep: applet/$(TARGET).eep
lss: applet/$(TARGET).lss 
sym: applet/$(TARGET).sym

# Program the device.  
upload: applet/$(TARGET).hex
	$(AVRDUDE) $(AVRDUDE_FLAGS) $(AVRDUDE_WRITE_FLASH)


	# Display size of file.
HEXSIZE = $(SIZE) --target=$(FORMAT) applet/$(TARGET).hex
ELFSIZE = $(SIZE)  applet/$(TARGET).elf
sizebefore:
	@if [ -f applet/$(TARGET).elf ]; then echo; echo $(MSG_SIZE_BEFORE); $(HEXSIZE); echo; fi

sizeafter:
	@if [ -f applet/$(TARGET).elf ]; then echo; echo $(MSG_SIZE_AFTER); $(HEXSIZE); echo; fi


# Convert ELF to COFF for use in debugging / simulating in AVR Studio or VMLAB.
COFFCONVERT=$(OBJCOPY) --debugging \
--change-section-address .data-0x800000 \
--change-section-address .bss-0x800000 \
--change-section-address .noinit-0x800000 \
--change-section-address .eeprom-0x810000 


coff: applet/$(TARGET).elf
	$(COFFCONVERT) -O coff-avr applet/$(TARGET).elf $(TARGET).cof


extcoff: $(TARGET).elf
	$(COFFCONVERT) -O coff-ext-avr applet/$(TARGET).elf $(TARGET).cof


.SUFFIXES: .elf .hex .eep .lss .sym

.elf.hex:
	$(OBJCOPY) -O $(FORMAT) -R .eeprom $< $@

.elf.eep:
	-$(OBJCOPY) -j .eeprom --set-section-flags=.eeprom="alloc,load" \
	--change-section-lma .eeprom=0 -O $(FORMAT) $< $@

# Create extended listing file from ELF output file.
.elf.lss:
	$(OBJDUMP) -h -S $< > $@

# Create a symbol table from ELF output file.
.elf.sym:
	$(NM) -n $< > $@

	# Link: create ELF output file from library.
applet/$(TARGET).elf: $(TARGET).pde applet/core.a 
	$(CC) $(ALL_CFLAGS) -o $@ applet/$(TARGET).cpp -L. applet/core.a $(LDFLAGS)

applet/core.a: $(OBJ)
	@for i in $(OBJ); do echo $(AR) rcs applet/core.a $$i; $(AR) rcs applet/core.a $$i; done



# Compile: create object files from C++ source files.
.cpp.o:
	$(CXX) -c $(ALL_CXXFLAGS) $< -o $@ 

# Compile: create object files from C source files.
.c.o:
	$(CC) -c $(ALL_CFLAGS) $< -o $@ 


# Compile: create assembler files from C source files.
.c.s:
	$(CC) -S $(ALL_CFLAGS) $< -o $@


# Assemble: create object files from assembler source files.
.S.o:
	$(CC) -c $(ALL_ASFLAGS) $< -o $@


# Automatic dependencies
%.d: %.c
	$(CC) -M $(ALL_CFLAGS) $< | sed "s;$(notdir $*).o:;$*.o $*.d:;" > $@

%.d: %.cpp
	$(CXX) -M $(ALL_CXXFLAGS) $< | sed "s;$(notdir $*).o:;$*.o $*.d:;" > $@


# Target: clean project.
clean:
	$(REMOVE) applet/$(TARGET).hex applet/$(TARGET).eep applet/$(TARGET).cof applet/$(TARGET).elf \
	applet/$(TARGET).map applet/$(TARGET).sym applet/$(TARGET).lss applet/core.a \
	$(OBJ) $(LST) $(SRC:.c=.s) $(SRC:.c=.d) $(CXXSRC:.cpp=.s) $(CXXSRC:.cpp=.d)

.PHONY:	all build elf hex eep lss sym program coff extcoff clean applet_files sizebefore sizeafter

-include $(SRC:.c=.d)
-include $(CXXSRC:.cpp=.d)'! !


!ArduinoType class methodsFor: 'as yet unclassified'!
allFriendlyNames
	| t1 |
	t1 := OrderedCollection new.
	self allTypes
		do: [:t2 | t2 friendlyNames
				do: [:t3 | t1 add: t3 asSymbol]].
	^ t1 asArray! !

!ArduinoType class methodsFor: 'as yet unclassified'!
allTypes
	^ self allSubclasses! !

!ArduinoType class methodsFor: 'as yet unclassified'!
withFriendlyName: t1 
	^ (self allTypes
		select: [:t2 | t2 friendlyNames includes: t1]) anyOne! !

!ArduinoType class methodsFor: 'accessing'!
avrdudeProgrammer
	^ 'stk500'! !

!ArduinoType class methodsFor: 'accessing'!
fCpu
	^ self subclassResponsibility! !

!ArduinoType class methodsFor: 'accessing'!
friendlyNames
	^ self subclassResponsibility! !

!ArduinoType class methodsFor: 'accessing'!
mcu
	^ self subclassResponsibility! !

!ArduinoType class methodsFor: 'accessing'!
uploadRate
	^ self subclassResponsibility! !


!ArduinoATmega168 class methodsFor: 'as yet unclassified'!
fCpu
	^ 16000000! !

!ArduinoATmega168 class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'ng or older w/ atmega168'}! !

!ArduinoATmega168 class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega168'! !

!ArduinoATmega168 class methodsFor: 'as yet unclassified'!
uploadRate
	^ 19200! !


!ArduinoATmega328 class methodsFor: 'as yet unclassified'!
fCpu
	^ 16000000! !

!ArduinoATmega328 class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'duemilanove w/ atmega328'. 'nano w/ atmega328'}! !

!ArduinoATmega328 class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega328p'! !

!ArduinoATmega328 class methodsFor: 'as yet unclassified'!
uploadRate
	^ 57600! !


!ArduinoATmega8 class methodsFor: 'as yet unclassified'!
fCpu
	^ '16000000'! !

!ArduinoATmega8 class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'ng or older w/ atmega8'}! !

!ArduinoATmega8 class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega8'! !

!ArduinoATmega8 class methodsFor: 'as yet unclassified'!
uploadRate
	^ 19200! !


!ArduinoBT class methodsFor: 'as yet unclassified'!
fCpu
	^ 16000000! !

!ArduinoBT class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'bluetooth'}! !

!ArduinoBT class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega168'! !

!ArduinoBT class methodsFor: 'as yet unclassified'!
uploadRate
	^ 19200! !


!ArduinoDiecimila class methodsFor: 'as yet unclassified'!
fCpu
	^ 16000000! !

!ArduinoDiecimila class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'diecimila w/ atmega168'. 'duemilanove w/ atmega168'. 'nano w/ atmega168'}! !

!ArduinoDiecimila class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega168'! !

!ArduinoDiecimila class methodsFor: 'as yet unclassified'!
uploadRate
	^ 19200! !


!ArduinoLilyPad class methodsFor: 'as yet unclassified'!
fCpu
	^ 8000000! !

!ArduinoLilyPad class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'lilypad w/ atmega168'}! !

!ArduinoLilyPad class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega168'! !

!ArduinoLilyPad class methodsFor: 'as yet unclassified'!
uploadRate
	^ 19200! !


!ArduinoLilyPad328 class methodsFor: 'as yet unclassified'!
fCpu
	^ 8000000! !

!ArduinoLilyPad328 class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'lilypad w/ atmega328'}! !

!ArduinoLilyPad328 class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega328p'! !

!ArduinoLilyPad328 class methodsFor: 'as yet unclassified'!
uploadRate
	^ 57600! !


!ArduinoMega class methodsFor: 'as yet unclassified'!
fCpu
	^ 16000000! !

!ArduinoMega class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'mega'}! !

!ArduinoMega class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega1280'! !

!ArduinoMega class methodsFor: 'as yet unclassified'!
uploadRate
	^ 57600! !


!ArduinoMini class methodsFor: 'as yet unclassified'!
fCpu
	^ 16000000! !

!ArduinoMini class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'mini'}! !

!ArduinoMini class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega168'! !

!ArduinoMini class methodsFor: 'as yet unclassified'!
uploadRate
	^ 19200! !


!ArduinoPro class methodsFor: 'as yet unclassified'!
fCpu
	^ 8000000! !

!ArduinoPro class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'pro w/ atmega168'. 'pro mini w/ atmega168'}! !

!ArduinoPro class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega168'! !

!ArduinoPro class methodsFor: 'as yet unclassified'!
uploadRate
	^ 19200! !


!ArduinoPro328 class methodsFor: 'as yet unclassified'!
fCpu
	^ 8000000! !

!ArduinoPro328 class methodsFor: 'as yet unclassified'!
friendlyNames
	^ {'pro w/ atmega328'. 'pro mini w/ atmega328'}! !

!ArduinoPro328 class methodsFor: 'as yet unclassified'!
mcu
	^ 'atmega328p'! !

!ArduinoPro328 class methodsFor: 'as yet unclassified'!
uploadRate
	^ 57600! !

