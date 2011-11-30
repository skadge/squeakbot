'From etoys4.0 of 9 October 2008 [latest update: #2340] on 19 December 2010 at 10:04:27 pm'!
Object subclass: #Arduino
	instanceVariableNames: 'protocol digitalPins analogPins'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core'!

Object subclass: #ArduinoPin
	instanceVariableNames: 'number protocol'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core'!

ArduinoPin subclass: #ArduinoAnalogPin
	instanceVariableNames: 'isActive'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core'!

ArduinoPin subclass: #ArduinoDigitalPin
	instanceVariableNames: 'mode value'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core'!

Object subclass: #ArduinoProtocol
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core'!

Object subclass: #AttachableDevice
	instanceVariableNames: 'pin isConfigured'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!

AttachableDevice subclass: #Buzzer
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!
AttachableDevice subclass: #EButton
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!

ArduinoProtocol subclass: #Firmata
	instanceVariableNames: 'port analogInputData digitalInputData digitalOutputData parsingSysex storedInputData sysexBytesRead waitForData executeMultiByteCommand multiByteChannel majorVersion minorVersion steppingProcess'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Firmata'!

Object subclass: #FirmataConstants
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Firmata'!

Error subclass: #FirmataNotInstalledError
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Firmata'!

AttachableDevice subclass: #LightEmittingDiode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!

AttachableDevice subclass: #Photoresistor
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!

Object subclass: #PinMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!

PinMode subclass: #InputMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!

InputMode subclass: #ButtonMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!

PinMode subclass: #OutputMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!

OutputMode subclass: #LedMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!

PinMode class
	instanceVariableNames: 'uniqueInstance'!
AttachableDevice subclass: #Potentiometer
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!

AttachableDevice subclass: #PwmLightEmittingDiode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!
OutputMode subclass: #PwmMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!

AttachableDevice subclass: #Servo
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!

OutputMode subclass: #ServoMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!

AttachableDevice subclass: #Thermistor
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!
InputMode subclass: #TiltMode
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-PinMode'!
AttachableDevice subclass: #TiltSwitch
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Core-Devices'!

!Arduino methodsFor: 'connection'!
activateDigitalReports
	protocol activateDigitalPort: 0;
		 activateDigitalPort: 1! !

!Arduino methodsFor: 'connection'!
activateReports
	self activateDigitalReports.
	analogPins
		do: [:t1 | t1 activate]! !

!Arduino methodsFor: 'connection'!
connectOnPort: t1 
	protocol connectOnPort: t1.
	self reconfigurePins! !

!Arduino methodsFor: 'connection'!
deactivateDigitalReports
	protocol deactivateDigitalPort: 0;
		 deactivateDigitalPort: 1! !

!Arduino methodsFor: 'connection'!
deactivateReports
	self deactivateDigitalReports.
	analogPins
		do: [:t1 | t1 deactivate]! !

!Arduino methodsFor: 'connection'!
disconnect
	protocol disconnect! !

!Arduino methodsFor: 'connection'!
isConnected
	^ protocol isConnected! !

!Arduino methodsFor: 'connection'!
reconfigurePins
	digitalPins values , analogPins values
		do: [:t1 | t1 refresh]! !

!Arduino methodsFor: 'accessing'!
analogPin: t1 
	^ analogPins
		at: t1
		ifAbsent: [self inaccessiblePinError]! !

!Arduino methodsFor: 'accessing'!
digitalPin: t1 
	^ digitalPins
		at: t1
		ifAbsent: [self inaccessiblePinError]! !

!Arduino methodsFor: 'errors'!
inaccessiblePinError
	self error: 'Inaccessible pin'! !

!Arduino methodsFor: 'initialize-release'!
initialize
	digitalPins := Dictionary
				newFrom: ((2 to: 13)
						collect: [:t1 | t1
								-> (ArduinoDigitalPin on: protocol number: t1)]).
	analogPins := Dictionary
				newFrom: ((0 to: 5)
						collect: [:t1 | t1
								-> (ArduinoAnalogPin on: protocol number: t1)])! !

!Arduino methodsFor: 'private'!
setProtocol: t1 
	protocol := t1! !


!Arduino class methodsFor: 'just for testing'!
instancesConnected
	^ self allInstances
		select: [:t1 | t1 isConnected]! !

!Arduino class methodsFor: 'as yet unclassified'!
new
	self shouldNotImplement! !

!Arduino class methodsFor: 'as yet unclassified'!
on: t1 
	^ (self basicNew setProtocol: t1) initialize! !


!ArduinoPin methodsFor: 'accessing'!
number
	^ number! !

!ArduinoPin methodsFor: 'printing'!
printOn: t1 
	super printOn: t1.
	t1 nextPutAll: '(' , number asString , ')'! !

!ArduinoPin methodsFor: 'initializing'!
refresh
	self subclassResponsibility! !

!ArduinoPin methodsFor: 'private'!
setProtocol: t1 number: t2 
	protocol := t1.
	number := t2! !


!ArduinoAnalogPin methodsFor: 'as yet unclassified'!
activate
	isActive := true.
	self refresh! !

!ArduinoAnalogPin methodsFor: 'as yet unclassified'!
deactivate
	isActive := false.
	self refresh! !

!ArduinoAnalogPin methodsFor: 'as yet unclassified'!
isActive
	^ isActive! !

!ArduinoAnalogPin methodsFor: 'as yet unclassified'!
value
	^ protocol analogRead: number! !

!ArduinoAnalogPin methodsFor: 'initializing'!
initialize
	isActive := false! !

!ArduinoAnalogPin methodsFor: 'initializing'!
refresh
	isActive
		ifTrue: [protocol activateAnalogPin: number]
		ifFalse: [protocol deactivateAnalogPin: number]! !


!ArduinoDigitalPin methodsFor: 'initialize-release'!
initialize
	mode := OutputMode new.
	value := 0! !

!ArduinoDigitalPin methodsFor: 'initialize-release'!
refresh
	self refreshMode; refreshValue! !

!ArduinoDigitalPin methodsFor: 'mode'!
mode
	^ mode! !

!ArduinoDigitalPin methodsFor: 'mode'!
mode: t1 
	mode := t1.
	self refreshMode! !

!ArduinoDigitalPin methodsFor: 'mode'!
refreshMode
	mode refreshModeOn: number using: protocol! !

!ArduinoDigitalPin methodsFor: 'mode'!
setInput
	self mode: InputMode new! !

!ArduinoDigitalPin methodsFor: 'mode'!
setOutput
	self mode: OutputMode new! !

!ArduinoDigitalPin methodsFor: 'value'!
refreshValue
	mode isOutput
		ifTrue: [mode
				refreshValue: value
				on: number
				using: protocol]! !

!ArduinoDigitalPin methodsFor: 'value'!
value
	^ mode isOutput
		ifTrue: [value]
		ifFalse: [value := protocol digitalRead: number]! !

!ArduinoDigitalPin methodsFor: 'value'!
value: t1 
	value := t1.
	self refreshValue! !


!ArduinoPin class methodsFor: 'instance creation'!
new
	self shouldNotImplement! !

!ArduinoPin class methodsFor: 'instance creation'!
on: t1 number: t2 
	^ (self basicNew setProtocol: t1 number: t2) initialize! !


!ArduinoProtocol methodsFor: 'analog pins'!
activateAnalogPin: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'analog pins'!
analogRead: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'analog pins'!
deactivateAnalogPin: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'digital pins'!
activateDigitalPort: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'digital pins'!
deactivateDigitalPort: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'digital pins'!
digitalPin: t1 mode: t2 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'digital pins'!
digitalRead: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'digital pins'!
digitalWrite: t1 value: t2 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'servos'!
attachServoToPin: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'servos'!
detachServoFromPin: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'servos'!
servoOnPin: t1 angle: t2 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'connection'!
connectOnPort: t1 
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'connection'!
disconnect
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'connection'!
isConnected
	self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'pin modes'!
valueForInputMode
	^ self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'pin modes'!
valueForOutputMode
	^ self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'pin modes'!
valueForPwmMode
	^ self subclassResponsibility! !

!ArduinoProtocol methodsFor: 'pin modes'!
valueForServoMode
	^ self subclassResponsibility! !


!AttachableDevice methodsFor: 'attaching'!
attach: t1 
	pin := t1.
	[self configure.
	isConfigured := true]
		on: Error
		do: [isConfigured := false]! !

!AttachableDevice methodsFor: 'attaching'!
controlAttaching
	self isAttached
		ifFalse: [^ self unattachedError]! !

!AttachableDevice methodsFor: 'attaching'!
detach
	self controlAttaching.
	[self deleteConfiguration]
		on: Error
		do: [].
	pin := nil! !

!AttachableDevice methodsFor: 'attaching'!
isAttached
	^ pin notNil! !

!AttachableDevice methodsFor: 'configuring'!
configure
	self subclassResponsibility! !

!AttachableDevice methodsFor: 'configuring'!
deleteConfiguration
	self subclassResponsibility! !

!AttachableDevice methodsFor: 'configuring'!
reconfigureIfNecessary
	isConfigured
		ifFalse: [self attach: pin]! !

!AttachableDevice methodsFor: 'errors'!
unattachedError
	^ self error: 'Unattached device: ' , self asString! !


!Buzzer methodsFor: 'configuring'!
configure
	pin mode: PwmMode new! !

!Buzzer methodsFor: 'configuring'!
deleteConfiguration
	pin setOutput! !

!Buzzer methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !

!Buzzer methodsFor: 'accessing'!
value: t1 
	self controlAttaching; reconfigureIfNecessary.
	pin
		value: (t1 min: 255 max: 0)! !


!EButton methodsFor: 'configuring'!
configure
	pin mode: ButtonMode new! !

!EButton methodsFor: 'configuring'!
deleteConfiguration
	pin setOutput! !

!EButton methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !


!Firmata methodsFor: 'analog pins'!
activateAnalogPin: t1 
	self analogPinReport: t1 onOff: 1! !

!Firmata methodsFor: 'analog pins'!
analogPinReport: t1 onOff: t2 
	self port
		nextPutAll: (ByteArray
				with: (FirmataConstants reportAnalog bitOr: t1)
				with: t2)! !

!Firmata methodsFor: 'analog pins'!
analogRead: t1 
	^ analogInputData at: t1 + 1! !

!Firmata methodsFor: 'analog pins'!
deactivateAnalogPin: t1 
	self analogPinReport: t1 onOff: 0! !

!Firmata methodsFor: 'analog pins'!
setAnalogInput: t1 value: t2 
	analogInputData at: t1 + 1 put: t2! !

!Firmata methodsFor: 'digital pins'!
activateDigitalPort: t1 
	self digitalPortReport: t1 onOff: 1! !

!Firmata methodsFor: 'digital pins'!
analogWrite: t1 value: t2 
	| t3 |
	t3 := ByteArray new: 3 withAll: 0.
	t3
		at: 1
		put: (FirmataConstants analogMessage
				bitOr: (t1 bitAnd: 15));
		
		at: 2
		put: (t2 rounded bitAnd: 127);
		
		at: 3
		put: ((t2 rounded bitShift: -7)
				bitAnd: 127).
	self port nextPutAll: t3! !

!Firmata methodsFor: 'digital pins'!
deactivateDigitalPort: t1 
	self digitalPortReport: t1 onOff: 0! !

!Firmata methodsFor: 'digital pins'!
digitalPin: t1 mode: t2 
	t1 <= 7
		ifTrue: [self activateDigitalPort: 0]
		ifFalse: [self activateDigitalPort: 1].
	self pin: t1 mode: t2! !

!Firmata methodsFor: 'digital pins'!
digitalPortReport: t1 onOff: t2 
	self port
		nextPutAll: (ByteArray
				with: (FirmataConstants reportDigital bitOr: t1)
				with: t2)! !

!Firmata methodsFor: 'digital pins'!
digitalRead: t1 
	^ ((digitalInputData at: (t1 bitShift: -3)
			+ 1)
		bitShift: (t1 bitAnd: 7)
				* -1)
		bitAnd: 1! !

!Firmata methodsFor: 'digital pins'!
digitalWrite: t1 value: t2 
	| t3 t4 t5 |
	t3 := (t1 bitShift: -3)
				bitAnd: 15.
	t4 := 1
				bitShift: (t1 bitAnd: 7).
	t5 := ByteArray new: 3 withAll: 0.
	t2 = 0
		ifTrue: [digitalOutputData
				at: t3 + 1
				put: ((digitalOutputData at: t3 + 1)
						bitAnd: t4 bitInvert)]
		ifFalse: [digitalOutputData
				at: t3 + 1
				put: ((digitalOutputData at: t3 + 1)
						bitOr: t4)].
	t5
		at: 1
		put: (FirmataConstants digitalMessage bitOr: t3);
		
		at: 2
		put: ((digitalOutputData at: t3 + 1)
				bitAnd: 127);
		
		at: 3
		put: ((digitalOutputData at: t3 + 1)
				bitShift: -7).
	self port nextPutAll: t5! !

!Firmata methodsFor: 'digital pins'!
pin: t1 mode: t2 
	self port
		nextPutAll: (ByteArray
				with: FirmataConstants setPinMode
				with: t1
				with: t2)! !

!Firmata methodsFor: 'digital pins'!
setDigitalInputs: t1 data: t2 
	digitalInputData at: t1 + 1 put: t2! !

!Firmata methodsFor: 'servos'!
attachServoToPin: t1 
	self
		servoConfig: t1
		minPulse: 544
		maxPulse: 2400
		angle: 0! !

!Firmata methodsFor: 'servos'!
detachServoFromPin: t1 
	self pin: t1 mode: FirmataConstants pinModeOutput! !

!Firmata methodsFor: 'servos'!
servoConfig: t1 minPulse: t2 maxPulse: t3 angle: t4 
	| t5 |
	t5 := ByteArray new: 10.
	t5 at: 1 put: FirmataConstants startSysex;
		 at: 2 put: FirmataConstants servoConfig;
		 at: 3 put: t1;
		
		at: 4
		put: (t2 rounded bitAnd: 127);
		
		at: 5
		put: ((t2 rounded bitShift: -7)
				bitAnd: 127);
		
		at: 6
		put: (t3 rounded bitAnd: 127);
		
		at: 7
		put: ((t3 rounded bitShift: -7)
				bitAnd: 127);
		
		at: 8
		put: (t4 rounded bitAnd: 127);
		
		at: 9
		put: ((t4 rounded bitShift: -7)
				bitAnd: 127);
		 at: 10 put: FirmataConstants endSysex.
	self port nextPutAll: t5! !

!Firmata methodsFor: 'servos'!
servoOnPin: t1 angle: t2 
	self analogWrite: t1 value: t2! !

!Firmata methodsFor: 'connection'!
connectOnPort: t1 
	port := SerialPort new baudRate: FirmataConstants defaultBaudRate.
	port := port
				openPort: (('COM*' match: t1)
						ifTrue: [t1 asInteger]
						ifFalse: [t1]).
	self isConnected
		ifTrue: [self startSteppingProcess; controlFirmataInstallation]! !

!Firmata methodsFor: 'connection'!
disconnect
	self isConnected
		ifTrue: [self stopSteppingProcess.
			port close.
			port := nil.
			self initializeVariables]! !

!Firmata methodsFor: 'connection'!
isConnected
	^ port notNil! !

!Firmata methodsFor: 'error control'!
controlConnection
	self isConnected
		ifFalse: [^ self error: 'Serial port is not connected']! !

!Firmata methodsFor: 'error control'!
controlFirmataInstallation
	self isFirmataInstalled
		ifFalse: [self disconnect.
			^ FirmataNotInstalledError signal]! !

!Firmata methodsFor: 'other commands'!
endSysex
	self port
		nextPutAll: (ByteArray with: FirmataConstants endSysex)! !

!Firmata methodsFor: 'other commands'!
queryFirmware
	self startSysex.
	self port
		nextPutAll: (ByteArray with: FirmataConstants reportFirmware)! !

!Firmata methodsFor: 'other commands'!
queryVersion
	self port
		nextPutAll: (ByteArray with: FirmataConstants reportVersion)! !

!Firmata methodsFor: 'other commands'!
startSysex
	self port
		nextPutAll: (ByteArray with: FirmataConstants startSysex)! !

!Firmata methodsFor: 'initialize-release'!
initialize
	self initializeVariables! !

!Firmata methodsFor: 'initialize-release'!
initializeVariables
	digitalOutputData := Array new: 16 withAll: 0.
	digitalInputData := Array new: 16 withAll: 0.
	analogInputData := Array new: 16 withAll: 0.
	storedInputData := Array new: FirmataConstants maxDataBytes + 1 withAll: 0.
	parsingSysex := false.
	sysexBytesRead := waitForData := executeMultiByteCommand := multiByteChannel := majorVersion := minorVersion := 0! !

!Firmata methodsFor: 'testing'!
isFirmataInstalled
	| t1 t2 |
	t1 := Time millisecondClockValue.
	t2 := 5000.
	[self queryVersion.
	100 milliSeconds asDelay wait.
	self version > 0
		or: [(Time millisecondsSince: t1)
				> t2]] whileFalse.
	^ self version > 0! !

!Firmata methodsFor: 'accessing'!
majorVersion
	^ majorVersion! !

!Firmata methodsFor: 'accessing'!
majorVersion: t1 minorVersion: t2 
	majorVersion := t1.
	minorVersion := t2! !

!Firmata methodsFor: 'accessing'!
minorVersion
	^ minorVersion! !

!Firmata methodsFor: 'accessing'!
port
	self controlConnection.
	^ port! !

!Firmata methodsFor: 'accessing'!
version
	^ (majorVersion asString , '.' , minorVersion asString) asNumber! !

!Firmata methodsFor: 'receiving'!
parseCommandHeader: t1 
	| t2 |
	t1 < 240
		ifTrue: [t2 := t1 bitAnd: 240.
			multiByteChannel := t1 bitAnd: 15]
		ifFalse: [t2 := t1].
	t2 caseOf: {
		[FirmataConstants analogMessage] -> 
			[waitForData := 2.
			executeMultiByteCommand := t2].
		[FirmataConstants digitalMessage] -> 
			[waitForData := 2.
			executeMultiByteCommand := t2].
		[FirmataConstants setPinMode] -> 
			[waitForData := 2.
			executeMultiByteCommand := t2].
		[FirmataConstants reportDigital] -> 
			[waitForData := 1.
			executeMultiByteCommand := t2].
		[FirmataConstants startSysex] -> 
			[parsingSysex := true.
			sysexBytesRead := 0].
		[FirmataConstants reportVersion] -> 
			[waitForData := 2.
			executeMultiByteCommand := t2]}
		 otherwise: []! !

!Firmata methodsFor: 'receiving'!
parseData: t1 
	waitForData := waitForData - 1.
	storedInputData at: waitForData + 1 put: t1.
	(waitForData = 0
			and: [executeMultiByteCommand ~= 0])
		ifTrue: [executeMultiByteCommand caseOf: {
				[FirmataConstants analogMessage] -> [self setAnalogInput: multiByteChannel value: (storedInputData first bitShift: 7)
						+ storedInputData second].
				[FirmataConstants digitalMessage] -> [self setDigitalInputs: multiByteChannel data: (storedInputData first bitShift: 7)
						+ storedInputData second].
				[FirmataConstants reportVersion] -> [self majorVersion: storedInputData first minorVersion: storedInputData second]}
				 otherwise: [].
			executeMultiByteCommand := 0]! !

!Firmata methodsFor: 'receiving'!
parseSysex: t1 
	t1 = FirmataConstants endSysex
		ifTrue: [parsingSysex := false]
		ifFalse: [storedInputData at: sysexBytesRead + 1 put: t1.
			sysexBytesRead := sysexBytesRead + 1]! !

!Firmata methodsFor: 'receiving'!
processInput
	| t1 |
	t1 := port readByteArray.
	t1
		do: [:t2 | parsingSysex
				ifTrue: [self parseSysex: t2]
				ifFalse: [(waitForData > 0
							and: [t2 < 128])
						ifTrue: [self parseData: t2]
						ifFalse: [self parseCommandHeader: t2]]]! !

!Firmata methodsFor: 'printing'!
printOn: t1 
	super printOn: t1.
	t1 nextPutAll: '(' , self hash asString , ')'! !

!Firmata methodsFor: 'stepping'!
startSteppingProcess
	steppingProcess notNil
		ifTrue: [^ self].
	steppingProcess := [[self step.
			(Delay forMilliseconds: self stepTime) wait] repeat]
				forkNamed: self asString! !

!Firmata methodsFor: 'stepping'!
step
	[self processInput]
		on: Error
		do: [:t1 | 
			Transcript show: self asString , ': ' , t1 description;
				 cr.
			self initializeVariables]! !

!Firmata methodsFor: 'stepping'!
stepTime
	^ 1! !

!Firmata methodsFor: 'stepping'!
stopSteppingProcess
	steppingProcess isNil
		ifTrue: [^ self].
	steppingProcess terminate.
	steppingProcess := nil! !

!Firmata methodsFor: 'pin modes'!
valueForInputMode
	^ FirmataConstants pinModeInput! !

!Firmata methodsFor: 'pin modes'!
valueForOutputMode
	^ FirmataConstants pinModeOutput! !

!Firmata methodsFor: 'pin modes'!
valueForPwmMode
	^ FirmataConstants pinModePwm! !

!Firmata methodsFor: 'pin modes'!
valueForServoMode
	^ FirmataConstants pinModeServo! !


!Firmata class methodsFor: 'instance creation'!
onPort: t1 
	^ self new connectOnPort: t1! !


!FirmataConstants class methodsFor: 'message commands'!
analogMessage
	^ 224! !

!FirmataConstants class methodsFor: 'message commands'!
digitalMessage
	^ 144! !

!FirmataConstants class methodsFor: 'message commands'!
endSysex
	^ 247! !

!FirmataConstants class methodsFor: 'message commands'!
reportAnalog
	^ 192! !

!FirmataConstants class methodsFor: 'message commands'!
reportDigital
	^ 208! !

!FirmataConstants class methodsFor: 'message commands'!
reportVersion
	^ 249! !

!FirmataConstants class methodsFor: 'message commands'!
setPinMode
	^ 244! !

!FirmataConstants class methodsFor: 'message commands'!
startSysex
	^ 240! !

!FirmataConstants class methodsFor: 'message commands'!
systemReset
	^ 255! !

!FirmataConstants class methodsFor: 'as yet unclassified'!
defaultBaudRate
	^ 57600! !

!FirmataConstants class methodsFor: 'as yet unclassified'!
maxDataBytes
	^ 32! !

!FirmataConstants class methodsFor: 'version numbers'!
firmataMajorVersion
	^ 2! !

!FirmataConstants class methodsFor: 'version numbers'!
firmataMinorVersion
	^ 0! !

!FirmataConstants class methodsFor: 'version numbers'!
versionBlickPin
	^ 13! !

!FirmataConstants class methodsFor: 'extended command set using Sysex'!
firmataString
	^ 113! !

!FirmataConstants class methodsFor: 'extended command set using Sysex'!
reportFirmware
	^ 121! !

!FirmataConstants class methodsFor: 'extended command set using Sysex'!
servoConfig
	^ 112! !

!FirmataConstants class methodsFor: 'extended command set using Sysex'!
sysexNonRealtime
	^ 126! !

!FirmataConstants class methodsFor: 'extended command set using Sysex'!
sysexRealtime
	^ 127! !

!FirmataConstants class methodsFor: 'pin modes'!
pinModeAnalog
	^ 2! !

!FirmataConstants class methodsFor: 'pin modes'!
pinModeInput
	^ 0! !

!FirmataConstants class methodsFor: 'pin modes'!
pinModeOutput
	^ 1! !

!FirmataConstants class methodsFor: 'pin modes'!
pinModePwm
	^ 3! !

!FirmataConstants class methodsFor: 'pin modes'!
pinModeServo
	^ 4! !

!FirmataConstants class methodsFor: 'pin modes'!
pinModeUnavailable
	^ -1! !


!LightEmittingDiode methodsFor: 'configuring'!
configure
	pin mode: LedMode new! !

!LightEmittingDiode methodsFor: 'configuring'!
deleteConfiguration
	pin setOutput! !

!LightEmittingDiode methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !

!LightEmittingDiode methodsFor: 'accessing'!
value: t1 
	self controlAttaching; reconfigureIfNecessary.
	pin value: t1! !


!Photoresistor methodsFor: 'configuring'!
configure
	pin activate! !

!Photoresistor methodsFor: 'configuring'!
deleteConfiguration
	pin deactivate! !

!Photoresistor methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !


!PinMode methodsFor: 'testing'!
isOutput
	^ false! !

!PinMode methodsFor: 'accessing'!
nameSymbol
	^ #undefined! !

!PinMode methodsFor: 'setting pins'!
refreshModeOn: t1 using: t2 
	self subclassResponsibility! !

!PinMode methodsFor: 'setting pins'!
refreshValue: t1 on: t2 using: t3 
	self subclassResponsibility! !


!InputMode methodsFor: 'accessing'!
nameSymbol
	^ #input! !

!InputMode methodsFor: 'refreshing'!
refreshModeOn: t1 using: t2 
	t2 digitalPin: t1 mode: t2 valueForInputMode! !

!InputMode methodsFor: 'refreshing'!
refreshValue: t1 on: t2 using: t3 
	^ self error: 'Input mode cannot set value'! !


!ButtonMode methodsFor: 'accessing'!
nameSymbol
	^ #button! !


!OutputMode methodsFor: 'testing'!
isOutput
	^ true! !

!OutputMode methodsFor: 'accessing'!
nameSymbol
	^ #output! !

!OutputMode methodsFor: 'refresing'!
refreshModeOn: t1 using: t2 
	t2 digitalPin: t1 mode: t2 valueForOutputMode! !

!OutputMode methodsFor: 'refresing'!
refreshValue: t1 on: t2 using: t3 
	t3 digitalWrite: t2 value: t1! !


!LedMode methodsFor: 'accessing'!
nameSymbol
	^ #led! !


!PinMode class methodsFor: 'as yet unclassified'!
new
	^ uniqueInstance
		ifNil: [uniqueInstance := self basicNew]! !


!Potentiometer methodsFor: 'configuring'!
configure
	pin activate! !

!Potentiometer methodsFor: 'configuring'!
deleteConfiguration
	pin deactivate! !

!Potentiometer methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !


!PwmLightEmittingDiode methodsFor: 'configuring'!
configure
	pin mode: PwmMode new! !

!PwmLightEmittingDiode methodsFor: 'configuring'!
deleteConfiguration
	pin setOutput! !

!PwmLightEmittingDiode methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !

!PwmLightEmittingDiode methodsFor: 'accessing'!
value: t1 
	self controlAttaching; reconfigureIfNecessary.
	pin
		value: (t1 min: 255 max: 0)! !


!PwmMode methodsFor: 'accessing'!
nameSymbol
	^ #pwm! !

!PwmMode methodsFor: 'refreshing'!
refreshModeOn: t1 using: t2 
	t2 digitalPin: t1 mode: t2 valueForPwmMode! !

!PwmMode methodsFor: 'refreshing'!
refreshValue: t1 on: t2 using: t3 
	t3 analogWrite: t2 value: t1! !


!Servo methodsFor: 'accessing'!
angle
	^ pin value! !

!Servo methodsFor: 'accessing'!
angle: t1 
	self controlAttaching; reconfigureIfNecessary.
	pin
		value: (t1 min: 180 max: 0)! !

!Servo methodsFor: 'configuring'!
configure
	pin mode: ServoMode new! !

!Servo methodsFor: 'configuring'!
deleteConfiguration
	pin setOutput! !

!Servo methodsFor: 'initialize-release'!
initialize
	super initialize! !


!ServoMode methodsFor: 'accessing'!
nameSymbol
	^ #servo! !

!ServoMode methodsFor: 'refreshing'!
refreshModeOn: t1 using: t2 
	t2 attachServoToPin: t1;
		 digitalPin: t1 mode: t2 valueForServoMode! !

!ServoMode methodsFor: 'refreshing'!
refreshValue: t1 on: t2 using: t3 
	t3 servoOnPin: t2 angle: t1! !


!Thermistor methodsFor: 'configuring'!
configure
	pin activate! !

!Thermistor methodsFor: 'configuring'!
deleteConfiguration
	pin deactivate! !

!Thermistor methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !


!TiltMode methodsFor: 'as yet unclassified'!
nameSymbol
	^ #tilt! !


!TiltSwitch methodsFor: 'configuring'!
configure
	pin mode: TiltMode new! !

!TiltSwitch methodsFor: 'configuring'!
deleteConfiguration
	pin setOutput! !

!TiltSwitch methodsFor: 'accessing'!
value
	self controlAttaching; reconfigureIfNecessary.
	^ pin value! !

