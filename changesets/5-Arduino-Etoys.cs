'From etoys4.0 of 9 October 2008 [latest update: #2340] on 19 December 2010 at 10:04:19 pm'!
Morph subclass: #ArduinoMorph
	instanceVariableNames: 'arduino boardType portName'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys'!

ArduinoMorph class
	instanceVariableNames: 'lastBoardType form lastPortName'!
Morph subclass: #ArduinoPinMorph
	instanceVariableNames: 'form pin attachmentPoint'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys'!

ArduinoPinMorph subclass: #ArduinoAnalogPinMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys'!

ArduinoPinMorph subclass: #ArduinoDigitalPinMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys'!

ArduinoPinMorph class
	instanceVariableNames: 'form'!
Player subclass: #ArduinoPlayer
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys'!
PEWireMorph subclass: #ArduinoWireMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Wiring'!

Morph subclass: #AttachableDeviceMorph
	instanceVariableNames: 'device attachmentPoint'
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

AttachableDeviceMorph class
	instanceVariableNames: 'form'!
Player subclass: #AttachableDevicePlayer
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!
AttachableDeviceMorph subclass: #BuzzerMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!
AttachableDeviceMorph subclass: #EButtonMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

AttachableDeviceMorph subclass: #LightDiodeMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

AttachableDeviceMorph subclass: #PhotoresistorMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

AttachableDeviceMorph subclass: #PotentiometerMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

EButtonMorph subclass: #PushButtonMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

AttachableDeviceMorph subclass: #PwmLightDiodeMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!
AttachableDeviceMorph subclass: #ServoMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

EButtonMorph subclass: #SwitchMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

AttachableDeviceMorph subclass: #ThermistorMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!
AttachableDeviceMorph subclass: #TiltSwitchMorph
	instanceVariableNames: ''
	classVariableNames: ''
	poolDictionaries: ''
	category: 'Arduino-Etoys-Devices'!

!ArduinoMorph methodsFor: 'analog pins'!
analogPin0
	^ [(arduino analogPin: 0) value]
		on: Error
		do: [-1]! !

!ArduinoMorph methodsFor: 'analog pins'!
analogPin1
	^ [(arduino analogPin: 1) value]
		on: Error
		do: [-1]! !

!ArduinoMorph methodsFor: 'analog pins'!
analogPin2
	^ [(arduino analogPin: 2) value]
		on: Error
		do: [-1]! !

!ArduinoMorph methodsFor: 'analog pins'!
analogPin3
	^ [(arduino analogPin: 3) value]
		on: Error
		do: [-1]! !

!ArduinoMorph methodsFor: 'analog pins'!
analogPin4
	^ [(arduino analogPin: 4) value]
		on: Error
		do: [-1]! !

!ArduinoMorph methodsFor: 'analog pins'!
analogPin5
	^ [(arduino analogPin: 5) value]
		on: Error
		do: [-1]! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin0Active
	^ (arduino analogPin: 0) isActive! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin0Active: t1 
	| t2 |
	t2 := arduino analogPin: 0.
	[t1
		ifTrue: [t2 activate]
		ifFalse: [t2 deactivate]]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin1Active
	^ (arduino analogPin: 1) isActive! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin1Active: t1 
	| t2 |
	t2 := arduino analogPin: 1.
	[t1
		ifTrue: [t2 activate]
		ifFalse: [t2 deactivate]]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin2Active
	^ (arduino analogPin: 2) isActive! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin2Active: t1 
	| t2 |
	t2 := arduino analogPin: 2.
	[t1
		ifTrue: [t2 activate]
		ifFalse: [t2 deactivate]]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin3Active
	^ (arduino analogPin: 3) isActive! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin3Active: t1 
	| t2 |
	t2 := arduino analogPin: 3.
	[t1
		ifTrue: [t2 activate]
		ifFalse: [t2 deactivate]]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin4Active
	^ (arduino analogPin: 4) isActive! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin4Active: t1 
	| t2 |
	t2 := arduino analogPin: 4.
	[t1
		ifTrue: [t2 activate]
		ifFalse: [t2 deactivate]]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin5Active
	^ (arduino analogPin: 5) isActive! !

!ArduinoMorph methodsFor: 'analog pins'!
isAnalogPin5Active: t1 
	| t2 |
	t2 := arduino analogPin: 5.
	[t1
		ifTrue: [t2 activate]
		ifFalse: [t2 deactivate]]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'accessing'!
boardType
	^ boardType! !

!ArduinoMorph methodsFor: 'accessing'!
boardType: t1 
	self isConnected
		ifTrue: [^ self].
	boardType := t1.
	self class lastBoardType: t1! !

!ArduinoMorph methodsFor: 'accessing'!
pinModeFromSymbol: t1 
	^ t1 caseOf: {
		[#output] -> [OutputMode new].
		[#input] -> [InputMode new]}! !

!ArduinoMorph methodsFor: 'accessing'!
portName
	^ portName! !

!ArduinoMorph methodsFor: 'accessing'!
portName: t1 
	self isConnected
		ifTrue: [^ self].
	portName := t1 = #'other...'
				ifTrue: [(FillInTheBlank request: 'Port name:') asSymbol]
				ifFalse: [t1].
	self class lastPortName: portName! !

!ArduinoMorph methodsFor: 'accessing'!
symbolFromPinMode: t1 
	^ t1 nameSymbol! !

!ArduinoMorph methodsFor: 'connection'!
connect
	[[arduino connectOnPort: portName]
		on: FirmataNotInstalledError
		do: [self installFirmataIfPossible]]
		on: Error
		do: [:t1 | self inform: t1 description]! !

!ArduinoMorph methodsFor: 'connection'!
disconnect
	arduino disconnect! !

!ArduinoMorph methodsFor: 'connection'!
isConnected
	^ arduino isConnected! !

!ArduinoMorph methodsFor: 'initialize-release'!
delete
	self isConnected
		ifTrue: [self disconnect].
	super delete! !

!ArduinoMorph methodsFor: 'initialize-release'!
initialize
	super initialize.
	self extent: self class form extent.
	arduino := Arduino on: Firmata new.
	boardType := self class lastBoardType.
	self initializePortName.
	self initializePins! !

!ArduinoMorph methodsFor: 'initialize-release'!
initializePins
	| t1 |
	t1 := 12 @ 125.
	6
		timesRepeat: [self
				addMorph: (ArduinoPinMorph justASketch center: self center + t1).
			t1 := t1 x + 13 @ t1 y].
	t1 := 104 @ 125.
	0
		to: 5
		do: [:t2 | 
			self
				addMorph: ((ArduinoAnalogPinMorph
						on: (arduino analogPin: t2))
						center: self center + t1).
			t1 := t1 x + 13 @ t1 y].
	t1 := -40 @ -124.
	2
		timesRepeat: [self
				addMorph: (ArduinoPinMorph justASketch center: self center + t1).
			t1 := t1 x + 13 @ t1 y].
	t1 := -14 @ -124.
	13
		to: 8
		by: -1
		do: [:t2 | 
			self
				addMorph: ((ArduinoDigitalPinMorph
						on: (arduino digitalPin: t2))
						center: self center + t1).
			t1 := t1 x + 13 @ t1 y].
	t1 := 78 @ -124.
	7
		to: 2
		by: -1
		do: [:t2 | 
			self
				addMorph: ((ArduinoDigitalPinMorph
						on: (arduino digitalPin: t2))
						center: self center + t1).
			t1 := t1 x + 13 @ t1 y].
	t1 := 156 @ -124.
	1
		to: 0
		by: -1
		do: [:t2 | 
			self
				addMorph: (ArduinoPinMorph justASketch center: self center + t1).
			t1 := t1 x + 13 @ t1 y]! !

!ArduinoMorph methodsFor: 'initialize-release'!
initializePortName
	| t1 t2 |
	t2 := PESerialPortList.
	t1 := (t2 availableSerialPorts , t2 availableUSBPorts) asSet asSortedCollection.
	t1 := t1 , #(#'other...' ).
	Vocabulary addStandardVocabulary: (SymbolListType new vocabularyName: #ArduinoPort;
			 symbols: t1).
	(t1 includes: self class lastPortName)
		ifFalse: [self class lastPortName: t1 first].
	portName := self class lastPortName! !

!ArduinoMorph methodsFor: 'initialize-release'!
newPlayerInstance
	^ ArduinoPlayer newUserInstance! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin10
	^ [(arduino digitalPin: 10) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin10Mode
	^ self digitalPinModeAt: 10! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin10Mode: t1 
	[self digitalPin: 10 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin10: t1 
	[(arduino digitalPin: 10)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin11
	^ [(arduino digitalPin: 11) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin11Mode
	^ self symbolFromPinMode: (arduino digitalPin: 11) mode! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin11Mode: t1 
	[self digitalPin: 11 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin11: t1 
	[(arduino digitalPin: 11)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin12
	^ [(arduino digitalPin: 12) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin12Mode
	^ self digitalPinModeAt: 12! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin12Mode: t1 
	[self digitalPin: 12 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin12: t1 
	[(arduino digitalPin: 12)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin13
	^ [(arduino digitalPin: 13) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin13Mode
	^ self digitalPinModeAt: 13! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin13Mode: t1 
	[self digitalPin: 13 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin13: t1 
	[(arduino digitalPin: 13)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin2
	^ [(arduino digitalPin: 2) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin2Mode
	^ self digitalPinModeAt: 2! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin2Mode: t1 
	[self digitalPin: 2 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin2: t1 
	[(arduino digitalPin: 2)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin3
	^ [(arduino digitalPin: 3) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin3Mode
	^ self digitalPinModeAt: 3! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin3Mode: t1 
	[self digitalPin: 3 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin3: t1 
	[(arduino digitalPin: 3)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin4
	^ [(arduino digitalPin: 4) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin4Mode
	^ self digitalPinModeAt: 4! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin4Mode: t1 
	[self digitalPin: 4 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin4: t1 
	[(arduino digitalPin: 4)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin5
	^ [(arduino digitalPin: 5) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin5Mode
	^ self digitalPinModeAt: 5! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin5Mode: t1 
	[self digitalPin: 5 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin5: t1 
	[(arduino digitalPin: 5)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin6
	^ [(arduino digitalPin: 6) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin6Mode
	^ self digitalPinModeAt: 6! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin6Mode: t1 
	[self digitalPin: 6 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin6: t1 
	[(arduino digitalPin: 6)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin7
	^ [(arduino digitalPin: 7) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin7Mode
	^ self digitalPinModeAt: 7! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin7Mode: t1 
	[self digitalPin: 7 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin7: t1 
	[(arduino digitalPin: 7)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin8
	^ [(arduino digitalPin: 8) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin8Mode
	^ self digitalPinModeAt: 8! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin8Mode: t1 
	[self digitalPin: 8 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin8: t1 
	[(arduino digitalPin: 8)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin9
	^ [(arduino digitalPin: 9) value = 1]
		on: Error
		do: [false]! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin9Mode
	^ self digitalPinModeAt: 9! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin9Mode: t1 
	[self digitalPin: 9 mode: t1]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin9: t1 
	[(arduino digitalPin: 9)
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPinModeAt: t1 
	^ self symbolFromPinMode: (arduino digitalPin: t1) mode! !

!ArduinoMorph methodsFor: 'digital pins'!
digitalPin: t1 mode: t2 
	(#(#output #. #input )
			includes: (self digitalPinModeAt: t1))
		ifFalse: [^ self].
	(arduino digitalPin: t1)
		mode: (self pinModeFromSymbol: t2)! !

!ArduinoMorph methodsFor: 'drawing'!
drawOn: t1 
	t1 translucentImage: self class form at: self bounds topLeft! !

!ArduinoMorph methodsFor: 'viewer category filter'!
filterViewerCategoryDictionary: t1 
	| t2 |
	super filterViewerCategoryDictionary: t1.
	t2 := self validCategories.
	t1 keys
		do: [:t3 | (t2 includes: t3)
				ifFalse: [t1 removeKey: t3]]! !

!ArduinoMorph methodsFor: 'viewer category filter'!
validCategories
	^ self class additionsToViewerCategories
		collect: [:t1 | t1 first]! !

!ArduinoMorph methodsFor: 'viewer category filter'!
wantsConnectionVocabulary
	^ false! !

!ArduinoMorph methodsFor: 'viewer category filter'!
wantsConnectorVocabulary
	^ false! !

!ArduinoMorph methodsFor: 'viewer category filter'!
wantsEmbeddingsVocabulary
	^ false! !

!ArduinoMorph methodsFor: 'installing firmata'!
installFirmataIfPossible
	| t1 |
	t1 := Smalltalk
				at: #ArduinoSketchUploader
				ifAbsent: [].
	t1 isNil
		ifTrue: [^ self inform: 'Firmata does not seem to be installed.'].
	(self confirm: 'Firmata does not seem to be installed.
Do you want to install it now?')
		ifFalse: [^ self].
	[self
		showProgressBar: ((ProgressMorph label: 'Installing Firmata')
				subLabel: '(this might take a few seconds)')
		forSeconds: 15
		while: [Cursor wait
				showWhile: [t1 new
						uploadFirmataOnPort: portName
						arduinoType: ((Smalltalk at: #ArduinoType)
								withFriendlyName: boardType)]]]
		on: (Smalltalk at: #UploadingSketchError)
				, (Smalltalk at: #CompilingSketchError)
		do: [^ self inform: 'Installing Firmata failed for unknown reasons.
Make sure you selected the correct board type.
IMPORTANT: Unplug and replug your arduino before proceeding'].
	self inform: 'Firmata was successfully installed. 
You may try to connect to your board again.'! !

!ArduinoMorph methodsFor: 'installing firmata'!
showProgressBar: t1 forSeconds: t2 while: t3 
	| t4 |
	t1 openInWorld.
	t4 := [t2 * 10
				timesRepeat: [(Delay forMilliseconds: 100) wait.
					t1 incrDone: 0.1 / t2].
			t1 delete] fork.
	[t3 value]
		on: Error
		do: [:t5 | 
			t4 terminate.
			t1 done: 1.
			(Delay forMilliseconds: 200) wait.
			t1 delete.
			t5 signal].
	t4 terminate.
	t1 done: 1.
	(Delay forMilliseconds: 200) wait.
	t1 delete! !

!ArduinoMorph methodsFor: 'as yet unclassified'!
isConnectable
	^ false! !

!ArduinoMorph methodsFor: 'fileOut'!
prepareToBeSaved
	super prepareToBeSaved.
	self isConnected
		ifTrue: [self disconnect]! !


!ArduinoMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#'arduino - connection' #(#(#command #connect '') #(#command #disconnect '') #(#slot #isConnected '' #Boolean #readOnly #Player #getIsConnected #Player #unused) #(#slot #portName '' #ArduinoPort #readWrite #Player #getPortName #Player #setPortName:) #(#slot #boardType '' #ArduinoType #readWrite #Player #getBoardType #Player #setBoardType:))) #(#'arduino - digital pins mode' #(#(#slot #'digitalPin 2Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin2Mode #Player #setDigitalPin2Mode:) #(#slot #'digitalPin 3Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin3Mode #Player #setDigitalPin3Mode:) #(#slot #'digitalPin 4Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin4Mode #Player #setDigitalPin4Mode:) #(#slot #'digitalPin 5Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin5Mode #Player #setDigitalPin5Mode:) #(#slot #'digitalPin 6Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin6Mode #Player #setDigitalPin6Mode:) #(#slot #'digitalPin 7Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin7Mode #Player #setDigitalPin7Mode:) #(#slot #'digitalPin 8Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin8Mode #Player #setDigitalPin8Mode:) #(#slot #'digitalPin 9Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin9Mode #Player #setDigitalPin9Mode:) #(#slot #'digitalPin 10Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin10Mode #Player #setDigitalPin10Mode:) #(#slot #'digitalPin 11Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin11Mode #Player #setDigitalPin11Mode:) #(#slot #'digitalPin 12Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin12Mode #Player #setDigitalPin12Mode:) #(#slot #'digitalPin 13Mode' '' #ArduinoPinMode #readWrite #Player #getDigitalPin13Mode #Player #setDigitalPin13Mode:))) #(#'arduino - digital pins' #(#(#slot #'digitalPin 10' '' #Boolean #readWrite #Player #getDigitalPin10 #Player #setDigitalPin10:) #(#slot #'digitalPin 11' '' #Boolean #readWrite #Player #getDigitalPin11 #Player #setDigitalPin11:) #(#slot #'digitalPin 12' '' #Boolean #readWrite #Player #getDigitalPin12 #Player #setDigitalPin12:) #(#slot #'digitalPin 13' '' #Boolean #readWrite #Player #getDigitalPin13 #Player #setDigitalPin13:) #(#slot #'digitalPin 2' '' #Boolean #readWrite #Player #getDigitalPin2 #Player #setDigitalPin2:) #(#slot #'digitalPin 3' '' #Boolean #readWrite #Player #getDigitalPin3 #Player #setDigitalPin3:) #(#slot #'digitalPin 4' '' #Boolean #readWrite #Player #getDigitalPin4 #Player #setDigitalPin4:) #(#slot #'digitalPin 5' '' #Boolean #readWrite #Player #getDigitalPin5 #Player #setDigitalPin5:) #(#slot #'digitalPin 6' '' #Boolean #readWrite #Player #getDigitalPin6 #Player #setDigitalPin6:) #(#slot #'digitalPin 7' '' #Boolean #readWrite #Player #getDigitalPin7 #Player #setDigitalPin7:) #(#slot #'digitalPin 8' '' #Boolean #readWrite #Player #getDigitalPin8 #Player #setDigitalPin8:) #(#slot #'digitalPin 9' '' #Boolean #readWrite #Player #getDigitalPin9 #Player #setDigitalPin9:))) #(#'arduino - analog pins' #(#(#slot #'isAnalogPin 0Active' '' #Boolean #readWrite #Player #getIsAnalogPin0Active #Player #setIsAnalogPin0Active:) #(#slot #'isAnalogPin 1Active' '' #Boolean #readWrite #Player #getIsAnalogPin1Active #Player #setIsAnalogPin1Active:) #(#slot #'isAnalogPin 2Active' '' #Boolean #readWrite #Player #getIsAnalogPin2Active #Player #setIsAnalogPin2Active:) #(#slot #'isAnalogPin 3Active' '' #Boolean #readWrite #Player #getIsAnalogPin3Active #Player #setIsAnalogPin3Active:) #(#slot #'isAnalogPin 4Active' '' #Boolean #readWrite #Player #getIsAnalogPin4Active #Player #setIsAnalogPin4Active:) #(#slot #'isAnalogPin 5Active' '' #Boolean #readWrite #Player #getIsAnalogPin5Active #Player #setIsAnalogPin5Active:) #(#slot #'analogPin 0' '' #Number #readOnly #Player #getAnalogPin0 #Player #unused) #(#slot #'analogPin 1' '' #Number #readOnly #Player #getAnalogPin1 #Player #unused) #(#slot #'analogPin 2' '' #Number #readOnly #Player #getAnalogPin2 #Player #unused) #(#slot #'analogPin 3' '' #Number #readOnly #Player #getAnalogPin3 #Player #unused) #(#slot #'analogPin 4' '' #Number #readOnly #Player #getAnalogPin4 #Player #unused) #(#slot #'analogPin 5' '' #Number #readOnly #Player #getAnalogPin5 #Player #unused))) )! !

!ArduinoMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Arduino board'
		categories: #('Electronics' )
		documentation: ''! !

!ArduinoMorph class methodsFor: 'form'!
form
	^ form
		ifNil: [self initializeForm]! !

!ArduinoMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAAYMAAAEOCAYAAABrSnsUAAAABHNCSVQFBQUBSsjp7wAASkFJ
REFUeF7lXS10szAUraysrKycrKysnJysrKxEIiuRyMrKycnKycnJysnJyc/144Y8CGmAQGkL
3J2Tk71CSAjwfnJf3pv0+W+6iy7TIL6kdXThp/lpfpqf5qdTesL0p27anAh+mp/mp/lpfjr7
n0sY8GsA/DQ/zU/z09wWAr8G8Gw6vkz454Of5qf5LQR+zICURgkPWT0JdS3HHO1f3jaXl/Xr
Zfn65l+/bpqdn9T8/bTvp837wD/fQ3muIxcI/BLfn77VwpqYgkAYgnUcwmBScny5Xl9Wq1Wj
skxe5uZt1pd1w4J+mrcZXz9t3i/++W7fz6O+BwoLgV9j73bNsPJ6meZf11+cWgrWcfNFXi6X
l5eXl9LafJGbt8k/TByrKjjfZgD+bcbXT5v3i3++2/fzqO+BAkPg1/hvswgqrS3jernG79l/
EF2d73qRF4vFVSnThPzbpB+l0GjjKvJRmgygWZvx9dPm/eKf7/b9POp7oMAQ+C2A7r0InNcL
Y7cFEJT3by8Z2S8yymw2KxS8yGvjY7Q/GL82+Yfp08ZmAP5txtdPm/eNf77b9/Oo78H5ffJj
Blx0FxZXxtRtLyK1HHRQJV1CcmAMYezEDORFTnoqFLzMpobl+mDq21x/mGVtqhhAfZvx9XML
ZsA/3837edT30MWKAT9mMGC6M4tLeQ1Z1xfvIREEuk7PiyzsICq1DKo+mDJNqL4NP6Np288t
mAH/fDfv51HfQ9f8gR8zIPIrLmgQplUgL5IWABPtVppZCLYFEeb7EPgtgwFYBjdiBvzz3VPL
gB8z4KY7E7Rg8jtb4z84LYMrDKEGM+C3DPpoGdyOGfDPdx8tA37MgN+L6FaLy7FvYKKXgAoW
QsHt9FqQ2C+yeFa8vr4W6ipNyK9N8cNEjfNcpYwB+LUZXz9dYAb88+3fz6O+B37MgJ++dGNx
xc6dxSIMsp3IZTuVHZgBytvbW1Y2m02BdmlC/m3yDxM1znMVaWMzAP824+vnVsyAf76b9fOo
74EfM+CnL51gBq6lIp/+LYvCfpHNj8dVu3Zc+rUpfphNdpA2azO+fm7FDPjne9V6B/I9vwd+
zICfbvXQnRaGxCLytUhkb4KlQbbZSt9myz5/qIN2/dyCGfDPd/N+HvU98GMG/HTjh16JQWgG
P6nrT4LXWcdn2+AyT8ps41/PtmGj81WdtHlMP+O7nzbvF/989/9++DEDfrqRheCn8UfO6KSZ
F1FobFDjn39+mp8e5T4kfsxgpF5GjduL9h8Uw1aXRSvlp/lpfpo/vwE/ZsBPO+nw4/OyjI6N
28+T//dJ2++fX1WC99Nlxj+f/DQ//fB9SPyYAT/dCf3+9X15jd8vq0QggLn7tMe5P7+/l+j0
eVnsD5eXpBw+vy7nRCgs90f++eWn+ekH7UPixwz46c5oCIO3w7sSCMfkf5/2OC86fV3W8VEJ
hrUWJofPby1Q3O3nCY7xeT5fvn5+kvrn8vF9Vr9V9Qdr43ROz//SbSB8qsaHNjgP51eNx6bj
RKCpfpLxnZL2aw+LCXMh94P+tscPr/5Uu4bja0rDWpP7kfmua79Lxg9rsbGFmfT1dbb7qW6P
d6jJ/eC52/czC+JaC/bTen8W4WPen5Wnxc2PGfDTvaAhDPDx46XHCwyhgAIBMXfEQhJhIB8W
2kiN3+LsA3f396ItiWVScJ3N4aN2vPh4l4YFkjLc6vuDxYLz3jMBV30+GACsHekHcwLLp27+
fv/+svtBf8dPv/7QDvMM5nGv54vrYwlQjU9bc3XtMX48+6b9QRGA8ME8LEK/fBuYA3knwEh9
+jPfn4+vs1JE6sYn56P2vT+cuzuevJ8nlJqz8f7s9TfFjxnwa9yDofEBg2Gm5Wz8ny4fudrj
d5dGho9AadOe/WfCoMF4waB3yZh9zsdHr4SBx/VnBnMCDcaeMaiK9miD8YBx4HzFPDz6Qzsw
aCUMHvC8waB/jPsrtVg+TQHtf/1MSDcY39/fP1XDwlTWRMP7Qxu0bTIfUFY2R7/7wzz4Ps+5
Uib+DAvrZFg+/JgBP81PX2vsYard4yP701p1XXssQeB8FIDVbyKkavqD0Mosg5rzxTIQWgkD
fMw19wNBECkr4kv1dfToD0zm798/dT4YSLYcdaf5V0ttCeP0uZ+jXjZs2h+eKfpAezBCn/ZK
+GoM6mQvLZW0X2rrEP3g/ZmH9V5z0NDN98d3vjEPR8/3RywDodV7cfrkxwz4Ne7h0POKNdd5
6N6nAIYuS0l2jY+1sv8AH9mHOjdjhBXnQ1goAZCcDyYKTdDXa0ksAzW2+L3yfFgGueYcW5aB
f3+pJll9Pu4b94ICQee7xt6WxvULjKkKA/lMBRTmHMwttVzq+4OVszGe69wjRzcEIvrB+RDE
M499MThH+pEluqrzIWiwhp+9PzXvm0mLZYC2dRZI0TKILcuAHzPgpwdA42UvvOi73ETO1v9t
jUlr3Ee9nCQYwr/k4z58fnn3r0z2Gswg0xpbrpljfFgKK6zfVmAGQmeWQcP+fNaYTcYH5vTR
8v58aTDcDDT1eB9w7zgfysCvvbTUYX+4PpavMG+ZZdDg/vDe1WEG69haKmxwfRHuENjB+6ke
M/j5vbIY+TEDfo17MPS7sSwgDECWMg42Y3O0x4cMZpbuNfjUWEK5lwY+KoCzKEpjq9HYoXFC
Q5U2+DAXtbGZUs1MPH0wvlqvEL2OL/28a4+pJvO508tZdeeb9wPrw8fL5xYa/S1qvLaExjM/
aqcClD+9lFN1fRG60gYWVp2Xj0n7YgZ4N0Pj/cE7t6rBqCAMcJ75/pRZvEJj7OpZaiUHgkoJ
gxqLxX5/9p5eWfyYAT/dq30G+B8vr2hAqTD4KlmDThnft3ahKzL0itg5QeruKB80NNBZzU7p
hckAdF1YJy7pb2f0g/rKHbUEY5DzMc7CUofHfELLX0b1+yxwnnk/BdzkDs+7yDDrvbDMeSvg
BxXt3/SSF9q9xs0xh9wNs+r9iQvz5uNV9mLdD+pZUP/+BNb7swjju70//JgBP92bfQZg6GD8
4r8N7TD97bt0DRpLQum5X+o8qZusyfLT/DQ/zY8Z8NM9odca+IO7nYCaQq9KvC5UG8f5qBdt
8i3w0/w0f2wifsyAn+an+Wl+mj82ET9mwE8/mc5AXQk0Z6zhFtaarTXvuRXCAJ43AG2rMICZ
BiixpPTmsfNY2uDa4uXie3/SZlfjBWLSyh9dex91Mb/Be+peuDPHrb1o4OqZli/Vr+0uK7Gi
TJ99XAfny74GeT4viTWmftfXiwrBB3OvmllwvcbN/z24328XxoLfXe83fnNhHoXf+TEDfrrv
NBgOMIDMewa/JTU8MMqimb5LGABNn7S3DmII7Wq8LiQGUiEoXs14XxMQE2MrwzDKvEj2p0/t
Vujr1fKuhOKpI79/zIX46odqXnKvGDD5wiatoAheSiTYlGHn+xiUt87vn2qz1MDzWoe1wL2q
0CDnn2LIBe0DnwkWfb18PwD/91BQJD6/lHOEAOEIvoh5xRyX7bzH+XiW4rUFxQXPvu574McM
+OlexSaSDWMqiJwGhas0/FBrpqZPPhhcYW9CjcZc5/d/te+hpd+/b2wiE0Ppyu9fAqthbsB4
bS8WaPB5aI18h23qCnoojc3zZYawMLRQWA6ZlWEch3aK0A+F3djJcfjFzz28ZBhpuLtK4D08
jyzURo2Fjecs7qgv4YEfM+DXMK793qvrrq8XN95nAMYJP2lboyzbmQzPIzBn033uagt+RTTN
ptE6ffc9tI1NJHQxNMJtz9+MPZTG7iky/kgvrRVjL30ZUUOvry87sl3H83ktjmevg+5J+Adz
J7TPTmE22mTseG6o8VyuBGch9tNBvWt4NrAQIGivNlTyYwYkdJZu8nCZIOWkqqV40EG1hobj
ebuG1y988Nf7DLAjFi88NhhBCzrrUARV0R1nOmgcNhhJ+2wTUM18CdOCAPKJTWTue1jbbTxi
E0Hb9vFjNy0DFXQvPt70fmRavGL82gowjheC7u2KwdfAXCBsC9aQdU27PwgWl8UFi0+E3NrY
A4Bn7BPbh40+6WVTZZ3pfTV4VgVLyjgf7xe+ATPB00opAuer58ePGVRouJK0XeXsDeOrnL6D
0ShCEQSHm2rn9TVzv/n6LotBA2AzR+17/03Px05lMK2DRMj0mF+xDPBRBtbSSl1sIunPZ3zC
NNvEJrJprDXny0S/Vzunc8sgb4+wzK8a7MXSWKrNX8dqKsMobIsLfWNPCCw5XCu13Pgxg7qd
zk1idc10bCJn7C+Pnd/UmMFEMbgqjXZYOXyRhH7S1iKosxCya99+/anHzst709itDA1fwE6f
fAZgjtCwUqD7XFxaKekPbcAYZWOcD0ax0juDVV6Gz6/GGIULswDjRv92vH70dfxMQful4b0S
a+8iWCjbZG5Mxo816Df925Vni/bqskMgSLA1sXQgFEzMQLLcKQ+xMOa3EPj3GTwOM5gEcQtN
ued+wkFHmrsw7MJ8RZ1c13c+4Q2Bte13V+KZDjQuCT981DFwxBSviiYqIa+l3XJ/qF3zVa6l
Rj8rj53R0anYz7okn0OTfA0fene36YUCxmwmBjIzdqUhvr8zwWe6OUocI2lnu+dK1jk7dpTp
FWZ6Ncn45Ho7T4tr7LRYhk0wBvHKM58XnkfwfuLHDNpZBA56ABbCpKC936jBO+63E4vDFjSW
RrzXGjGWM/4UkPxRABv5NTh+moVWy2cNvKwkYx0EiFheex1IT+FO/JiBg755rVsny+8hDYab
jbdNHR5ULddL6yitjeM31dl18+tjaQFryhJx0c745RwPP81Pj5jG93DWThFmDebuwlgC7UUn
kUuhVMGyrIuOKjQhZpAyzIlmTGnxpNUDqLv+s+k4Wy5qfH+KYSf/V10/vGH+QuMFdlx/EaYh
eyXz1p9O5egT3ZGf5qfHRotloIDhMAWHhXadL4lscBwJeyQab9Gporw/OsygKVbgpTH3lo4z
ryjf2vf6CkNoXPuPHy+wALZvHWMGj6Cx5IXxr3Vi/7wuz5C2VODqu7Od5Hew+8Pv7n7eazGN
vtKYn7J5KMNc4DFVNg9VfvlNaeAsZf0sOuYPcJcOPHYOCw2MDQLkV7lZ/2l365QupBotaU+H
GRS15oYaLr+G2lt6IgJNLBB5Xj500P14ZJ+EhNiQGmCsYhqO9vhgYQ19GOdLnYHoVn9wW5Uw
3u9Wu71nhqu+0RAGyg31/HM1D0fZvGe1B9j6mzA++3wbTL11fADh1TNy9NMmZ3Of6FYMd7vd
Xvpa1ttd6qO+i5z1NIivli58azCO0uveUPOvkd5Id4BlTB1rsLfQ0GCxthsXdoxWt4eQUHkd
EiZYm8NZ6CAFCZvsNB0CjXuBVlvUjKs1dhGIiztaRHiW4vlkB+Eb+vfUThhsNkUmzE+3pl+3
Ab+GfytGErbHSIqYUHfjS5lT6iq5CGNPjTi1DhBsrC6nrklvFeP8LboPDvz5ZsJUucPWnw8m
Lekhl3fM2CY73jMPnRF9T6OzDJ5VNjdYMvwafnv6VgzIrCdh3Nn4vnUoDRXKQW8ck3php77U
7WO9BAH/frvda0mOZvyOJRVoxHY/+Q7pYT1fMPY/vUxkz4MrzDbaY8e0rI3b87DqUINXS3nJ
2GQDn9lPlmZzoN/TbcKAX8O/mX6FMODX8FvTN2FAV5hQd+PD+rErAxvKrMQCWUm2N0fGt7LY
SVhaapohrvd0EJVmsMvW5a32sKTK5rsAvndgsZTNt68FyI8Z8FsGFZYBv4bfmg7usf+Bf375
6WHQEjhyqi3kW2Kr8WMG/JjB4Ombd167Ppwbx7dV2cA+CxnBQFfFo4fWaZ8f6eWeecn4oPXu
rfPRHr+lIPQwn2+oN1CZ8yERZl3n43fXfKcRPLsbn3pGjvm2M/Tdfb60M4xi/tY+AnHnLjhF
8GMG/JgBlYVg7ZuYNKC7Ho8K8HY8Kea/0zXoT5X9y+31g6Ug+3zU2EWqAsw5+gOj21rno73E
wR/q88RykD1/qFXCHQfmslRzdz3fwFJCK2jeLePDstzOMd/AEJpkwLuZDn32Bdnn8WMG/JgB
P/1UrxgzCBtAzjqNHQz+3QjeBjA69Ih2inOkn0+d5Wro84f1eJkHlCxTW4VXEcBkmQd4WW0k
vlXHXkXwXpJ+zuLN9QCLYNJE48/O58cM+DEDfvrpFstaJ/UHyAnmsZGloor2shtZBe87pTkX
avcp6OQ5cHnEssnPCGI7zdVu5Hz+sJ/ipWYfwcqY79gMG97x+JZZP2mAxaOd2vReGEEQN45E
4LOPhh8z4McM+Ok70HA1VLuQjYxtUrKwBVZ7LI24zs+0W0d/uNa3dT7aQ4MuhCAY2PydtLZt
z8enmV3NCtLmOh/zsO7QqwrP4Vwy31UZ+Tqjw2uvskkWM+yQ76i320vMMX7MgB8zGDOtYtmE
0WW3T5ZK9vtLGKV1HAeXOAqu6ihKzlHnpm2WYeRcs0Zmsrbjm+m4QXMryFidBmefPw/i0lhG
5tLI3BXMbMDPd+aYh8r5K5vv4D77IK7n+zGxxq40/DJvuuDaoqjDGPgxA37MYPD0NmHmUSIA
9okAkPqQMP6/j8nl7zRV5R9qTZ8Or1fnb/fF66uk+gON7cNPj9VrLr7KQFi2z2Yaxs5oxvyY
AT9mMFr6JUgFQaQZu9SHxAL4ZwoCoz4dX6/OR70wQDcJB9x2fJJo5FsHq3vxiDWEcwAco02V
15FNRzqERQY0j+D57lSCljR2P9biZzVr3kudtQ3nI7aTT0a5Vu+b/YxKdobfhc72D1gM3iPW
lmQq5McM+DGD0dKvYVHDL1gGlkUgtMsyQI1ryfV32s+97fgQSgFr1VjTDyRBfE37vd4fgGUH
MDOVraqmP4CXp+80Eip2wKLN0HfCStTX9J4Oym2zLkc1BMZW7QJOQ0x/iCdVx+PDOxF+nNQc
I2x2lhv6EbGDzCWvuthcLguixquI3zLgxwwGTa/D5pbB5/HNaRmswvz6Rcug+fjAzGSNW5LB
17WHx1DqBpnSeaa38v6AbZheLCpk8405k/sQm0gxWU3v9eaxqvbpfR8zC6sgSDscHwRTtnFQ
svE9MD+Ja9/AxASPC3lXohKsgR8zGCdmYKwlTgr/D5NuuhN4HlRYBg0wg33ULWYAYSAupWBk
YFZYyrgKe2zlMwjVzuG0HRgNatDzEr9yLCXBrz4975DlwF0pq2SYFsJcC9OldpUFA4ZgBv1i
bzgz8hkgeqskFYKHj7SfdRiNFmPBbmOZ7z+1b+So+3nAfNs7jnfXCaeuNP4SLyR+zGBkmMGk
y9g8PainLbxglmqpqGghxFF4+X5fJWVplJR+P2wLFgG8ipaBvWYNV8W/bMPTu6xbez4fnC8b
v+y6zE9eNo252pkWg73Tuayf+AbM45k0LIOyecDzmDk0XAiLsnnoMpooBHtZP6bFcO9YXI3z
fQT8sYkIMIMO4/ln5Xk0NB91X1Ku7tdNz4KUoWPZqElZhZFqn5UgrcGQRONTGn2JRspP89OP
plMFMPY8P/bO0MhvGQwcMxinZdB+PvhpfpolWmmWurVqxaDB98SPGQweM8i1alPDHirtr/Hw
0/w0uYWws3J/SxRT/R1Nml6P3zLgxwyGjhnw0/w0P92RxcGPGfBjBn2h22IG1xqSWBo+NL/G
yU/z060sBH5LgB8z6BVmwG+R8NP89HMsBH6Nnh8z6A1m0OX982uI/DQ/3cxC4LcE+DGDvmAG
ZbFZ2tSTkF8j5Kf56UYWAr9Gz48Z9AUzmHR5/4/MYctP89NjsBD4LQF+zKA3mEGX9984g9R9
aOw2LiRKGYAGifAdiL/kE52Vnx6RhcCv0fNjBn3aZ5ALxLb9GwKoBxrZj87Qde/+VArOmmig
vjRiCf379y/PA8yvUXNYCPyWAD9m0Lt9BkGOIeRupn50XywC0AhkB6aKsrKD2nXc31/SRyFM
9w3Xg1BBfKCFeob8GjWNhcCv0fNjBn3bZzAWGsHqRBiEZtjmO/SHiJtZmG5+DZifbmMh8FsC
/JgBf2yi+9CIgClJ8LPk746MaIjeiWB6iFp60hm+kNegbM1+rRO+SOY1FX45swzy83E9Mz+C
tEdGL+RbsMcjuQNwXdTLigxj2+MpS94DoafaJPcY2ol/9PmITorzv3TGOMwHlqFm/Bp6fywE
fo2eHzPgj03UPY04/rAIEHoajBea+9wRnx7gMs5DbH3Uvwm+AIGA/AcnR4YvLOHgvLMWBMAj
IAgKloE+f68tE3t8GNPf39/V+BfJ8wJwjH7rMAOE9cYYBV8QIYb/s/DPxvkf+ppI6flhnFtI
FMSvsT/XQuC3BPgxg75hBghHvdtHlyAr+0sUh5coCpI60HVK76O9OieM0jbIh2BfDwwXmi60
UWimqBHSGsfB8JZaA4eWi0xcXWhcYIhgdm/amwj/p3kMiue/aeYuDFUyqsGjB7/NwyIG8q1z
Cc+sfAH/HJhBqK9h5xxWwgBComT8EAqZMCi5v5y5/+Y5ioMUu4BgK+Q01tiJyslgXA8CBb8v
Qv7otr2wEPg1en7MoE+YwSa8PQfydl+8PhKigLFhyQQMMv780gwoUksmsoSjMl/dkBHNpKHx
/ilGnC6RQBM/ytKMcT76F8vAzK4FJp9p5sb5WHKyl37m+vo2ZhBcCRTLMigZf0EYlNwfGDms
Avv42TG+V32PWWIasXK0wFxVZIzjpx9H81sG/JhBbzCDl6C7HMgLx/XBBJH1zO4fWi4Y6dnQ
uG/VuLCEgiUcCB70m9K/zn0IYIjrjCFWX/9XhIp13IUZ4F5TzbvoFZQKg3+l/RUtA/d4ZKnH
Pg5hAEFhni/CQOVztryW8HuKTfBr6M+m+TEDfsygN5jBa9hNDmTUr4mFYV8fTFCtZ1v9p/lv
/3Xmp78yXErtopanHJhBph177Ft4/ypaGGD2LsxAlqqy1JyGVv/rwAzM6/lgBkoYWMe/dDpL
8/wryyAosQz4NfSn0vyWAT9m0BvMAFhBU8vgdHx1Wgbr8FrQpsLg5MQUoFkDcO1CwxLgNvUG
0gJHC4jc26aIGawtRll2fWAf0L6Vtr/LPYBcmIEImjetkUMQgVn/U4Dz7ZhBahkUj0sOYdtL
Cdczc0+jFqxj3qnXWdPa//oznZJVlv7y/900P2bAjxnwYwYtMYN5UGEZNMAMkFB/5rh+ZhkY
/ePDxfLQOj4qrXsRxjdrWGC4YNCunb0nU2s2MINVdPS6PsYJRg7NHswYFgH+Ty2DT0vDj9Nj
2osH/Yib668DMwDT/jznnj5Y5soS+Dswg8wysLyGcjfa4tzLNTE36P+fCOBbNdzAtKpbvK9B
uQWL9+gtUSzCwnu5v3wc3pKyubzrWuhDtMvfQ22hzoLr8QO7gpcZ5gVzIBiWLB2agnSpLScs
JabeaenSo43B8GMG/JjBqPYZrIylItH04yi8fL8vdVkZ/y+Tj3GbnYc6TATBEtfS1zOvjw9o
l1kG6XF8iPgdNATF+9e5cNwenw+NDz37UI3jYPy5ZZCev0jmCf3nmmT99bGslTCSy0fCeIFJ
KC+o5Lorx74A/AbmASGEvtEffsvHkZ+P6+D+wdBx/ocuEEBm/6hhdcDjye4PSz+YR/t80DK/
uCaESRqz6fr+mtKT5J5uf19j5/XhoYb3St4v1HgfyyzVr+P66nwIkpk1/i+9zwJzgmcnoDue
j2lxBe+f6rjM34cOO4K5V8pL8i7cOn9C82MG/JhB7/YZwEIAQ8dST5OyCquvDy0rXZLIj4Ex
Zox4l2pfrZ8fP/1wehLE3b2vgfW+JLXLUoUwKMOwPo+rq/NRL4Pi+GE9CZajlvq0NQULQSwu
vJcQGHstuCEMINjxzuI9hUVrLkWq+bD+mswnv2XAjxnw50Dmp4dLd/neWu9rGYbV1DJAbbs7
Y6lMGDmY+ykTBqllAAwJjD8TBsl4IAxkeQ2Wm4np1KUq8OI//Bo9P2ZwL5o9NhE/fX96EnT4
vgbF93UZVlgGJRhWmWWgrFZj/LAMBO+BYFDLinqpDsIANJbSbMsAS4rye5VF0MZC4LcM+DGD
0ccmgrkNLUyKeXxmnT/j17gHR3f2vjquH3ZgGexLMANX7CmxDICnpEy/iBkIRgRnhKVu75vi
mB8z4McMBocZwDzfhvssFAUAuH2UhqGw63AfZucB7MM6r309AduyIGzi7bJLQWWAnoIfKB95
fo17YHR8k4Wgwp+XXB/4Fd6voqa/V15sWTnm/x/jbcEiwHu8cIzfxAzM/iA04HEFzzC8r0ex
AgzLAOfDchCPtUbCgB8z4McMhoIZbB3eG033GWzC4vXhQWRuyFKxibS7Hj5IaFnQtvC78nDh
17iHaSEE7Wqf60MovJglrKcXQfn1wNhnJcdxDLvM4ZUWS5gSbd3m+1Fi9V7jvW1mGfBjBgPB
DLjpMu+NpvsMUM+NDw2WwVn716uw0tbOWaWFOXbO8j8ffnowXlX8mMG4MAN2+rXFDuSy2ERv
RvRSaFDwb4f5vZHIoUb/c73jNgXx+J8HPz1MutqbiH+fwbAwA3J63WFsolVQxAyiBISDIFC7
Y63+rywD/ufBT4/EQuDfZzBQzICdVuEootsxg9R7w40ZAJATv21+zICf5qf5MQN+zKCn9FLh
Btd+3d/vL2kIiqOuNf0ebwoWAbyKltZOZFgEofbLhpCAR5HsRIaQ2BwsbyL+58FPE9L8lgE/
ZtA7Gl4WKx1i4rVBjTazIHJevxD7J+DfZ8BP89P8mAE/ZsBP89P8ND/NjxnwYwb8ND/NT/PT
/JgBP2bAT/PT/DQ/zY8Z8GMGw9hJGuudzM1qFf6Cf/74aX6aHzPgxwxGQHcQn54/Wio/zU/z
Ywb8mMHQY8t0FRuJfz75aX6aHzPgxwwGumbZZT4HK6MZ//zy00OmdzqxDcreSp3KjxnwYwbj
W7PMsIIuLQP++eWnh0cjr4GZg0MKQqsgoik/ZsCPGYybxgsZdpTTln8+8zIK2igENFJeYqc8
QqR86Wi7KPhNkud33T+/ZcCPGfSMjjvKZcs/n/z0cGkwfBUnyzqO0CmpZcCPGfBjBgx0oPGD
NoV//vjpEdAIp76QVJzG8UViAb9mCW667b/3lsF6F1xWCZN11ihBmNRGaUKXXbdl/ZJck1/D
4af5aX56iPSkz3/1GuQNOYODmF8D4af5aX66l/R8s7u8vL5dXtavl6Wub6UXyTUrMYPeC4Oq
Na4bvU/4NQJ+mp/mp/tGQxCsVqu7lFwgOPhpr4VBrQSN+f3Qa+iJtRbv235yS3+3ejWYgt4O
TVFH82uY/PSQLYK3+wmCTCC8bd2YQf8tgxqJSuCHbltA04K3TLlXztS2nDy9bMx5moQe4w2K
z6EYI6jh/Xawz2BqCnp+jZOfHhC9Wq3vLgxQxocZKC0yao4ZBMOJXVN6fzWYxyQouf86jdwV
66duvkrmu7FFcgsG1MN9BpnwDUWgN6ibWmS6nd1fHd2Nhdzi/rKa3yIwaZtp77abSxwHlzgK
VL3bbWoZ/Xbzmpy/TcpO1WHwdi0MxoYZFD+EpljBQDSGSn/6NvMRV1gEcYtYP3GNv397C+iW
2suiuScddrVf4gH7Mm6K9np7//zRZnPaZtr7cKcEweEQXqKkDoNtrTAIEuZ/SATBIa4QBuPD
DIoa9HREFkHG2Kuic5bcz6RKw66wKKoxlpLxBt1FDx1LbKLJAy2cSdDNfE1bzhd/LKluaZtp
g/lHCWPf7zdJ2SaMfuMlDKLk/Cg5fx9uyi2D0WEGzjVsI7791Vr5wDSGFjtt6zTsVhpe2fzV
rt03uN8gGkVsok5jLIX3x1haW8zBk/sfJWZwbRns9zslBFB8LQMIg2D3qv53WwYjxAzGTldq
VPaL5aNhl2hgk0JfLouiZLwV+QeuGJmXhRfXW3iVdFyPcdyZfqSF01ksp1YYT9SdBcS/78cp
DDabtwQDeEvqV12/1QoDnLvZrJPz11lNgxmMmm6xpuxnGVR7EXljBhVr4629eoJcw85K6Ef3
wQKcPNLC6QKbuGXfzaMsoBp6punZg+l7Ywb38yYaMWYw2n0CLTCQoWIGo7LoOsjY5oNxTQyG
3NoiEO+llvtKbrdI4mb9OWJS7fZRsrYeJUsq+4fW69AeT7t9PUIvH+VaSoMZjIlmwgzGFusl
iArunBmWVUO3s3Dy596ovy7uN7Cwunv1X/FeK2GgGXQQBJcwDDO6yxrXxfWFXu/jTjGr2e7O
AmG9TvrY82MG/JhB/zEDfpqfbuM1BWEAbX29zhnp29tbp5bA6+trdm30g99W+7g7DGZnCoT7
CIPZdj/O2EQ2PTcfwDa8zOeLy3yRlPk8r+cuOj1vtlzxYwY9wAwmljeYdz1krzF++iavqV3C
sBHl+NqzJujEItjtrsNEqKjK++722Zj0YhtclirI3Kuu326mVVyiKi+4sWAGq+iYJn2QY2+7
y0IzfNRSqujZy5IfM3gyZtCF33yTNWh+ehwYDCwDWALXnjWbTiwDXMe+tuovjDrf1zTfBHdb
JppLXKIxYwbr+FjMAJRMqMn0fcps8TIwzCDqEDOIWmIGcWcZxyYj2WfAT9/DQq62XCEMXNp7
V9gBruOyOqosg2nQziK4e6C6EgthNJhBwTLA8UQCFhj9bKasALsWy0CWjtA+/Pi8fP+k+UbX
yXXpYxOFj4lN1OnO3Z75rU8CM1aRtS/iGXQQ3+T18pToux6YgVq6SdbzUSAcqjR+MHOcj/NE
aFSdj/NwXWAHaBdVYQYt37+HuZaOBTOIT1+X8++vYtZmHZ0+c1ReLxMJo9+8vVyWy0UyES+X
1fJF1UkPl+l0mp8HYaCv/+/fP1VUHtKne6XE7WK5hHHzNUyHBtYqNtSzd+6OKafzvesBeX2B
6U5VOej/03oXRYo5RzU1BACYORiiq2A5aF9zHfN4ahlY48FY9Xjt8dfR2VhWK1UjUF20310Q
lwi1T6A6bEyT81EHu2ssRfoz+x/vPgNtGYj2v02EQbCDd8H2gpgd+B/WAQRCLgxesvYQLBAG
Wb7Rpv3fhY6bR7PcRdcPvq59oJds2o4vuOH+QpTD5eZYO314XmF393NvWr0jbe83yKOmZozQ
m+5mvnf7lEHvK2ow+jpGigLtH0Kj7nqosc+gy/fHHgvCTxziQJVYMfb6ewiCbRbcLi4Jbufq
f5CYQcFryDie/p7StmWw3SxTYRBuL3sVtyMVBteWQayFwZdlGVz3x0/fh35MtM870vj/lvE/
rY6f8rwy4XDD/AfGPgO7BuN2gct1BctCruuZ9WsYdfr+2GNAbCIEqkuDzm09YxOlwmC/T62K
0BHcztX/IDGDr/PPtURN1vYPJZiBLBNBAGy3r4np9apqUxiYmAHaRx+GZfB0i4CPljX2pqUf
FsFhMBbBTdFDgw5jI8mzazn/VZaBy+XU10JQWEKdZdDh+3NlGYRbxdAlSJ1P1FIV6VQLgbTd
xm0ZWP0PEjP4SsBd0cA2hw/1+zph2qk3UVRqGSi8QJUUO4AgcGEGLstguT8qgSPH0e9Mj2G5
P1yOX9+X96SgTkHndLygMS4IqjclWGJ+C2DE9KQLy+bZdRA/xQK6Zf7LLAOXF1CTAovCzzLo
5v2x+98mmAGS1Wy3b1ldN2YEtDPPd7UZDWaghMEuXRb61FaC8ib6+jYwg53S/KUAM5jPp5eX
l9llmZRF8j/wApTsvArMYHc8KQEhx0/f51Q4JP8fPr8U6AzBsT1+XD6SYzLe378/dQ0cw1j7
hUHw051jOkO1CFphLl3eb3wXzMAXJ6gq+0SgPAszuFcZDWYAppp7Ef0Z3kRf+fnbMGP2KLAM
YAWYv10VbDorwQx27yftrZQexxiW2gJAjf4XjjXXv79/uSmbXGMvAoVfox4dnYKoh+FbBuay
Td39P7q/hphBG6ygCXbQOWaw5s+B3HlsosmmKAyAGdQJg+lyXYoZ7BKNPzIYuWkZgIZFoKwU
ywvnL7EMsG8B5ZwILSwp8WvQI6WDePAWgTOLXsX9e2UYrKGVV9GN8++0DJLSBeME5vAozGC6
xZjvKxBmiaI8Gswg9RwqmrIvwmTl/BaWwdSITWRbBkFmGUSWZZCPTy0XfX4VxvuXXANt041s
vwp74Neox+oFNR7LoNEafpC60U61ZdSo7ghDc1kG+xvxggJu8CDMADSiit7LQlARS8ve3yFi
BliTV8CxwbjBaM01fdsy2DaxDBpiBhlorZewBNQWzCBb11RC4cSvQY+UHoNFUNDYBzT/ZZjB
QyyDO9wP4hMhuNzLOg0096KDzd1CqzAUVe/vEDGD1JsoUmv0YL7QunNvovhGy8CNGUAoCKNH
AUYw05oNzt0nY8C5GMuXLBdpywC/b/QyUgYg82vUI6Pj0VgEQ8xJfE/MQDagPQIzUPuo7hio
bpFcuxTzGiJmIDGDED9I1vQRqM7cZ9AGM5i8rCr3GQAXiPVS0FqsAr1EBUsidSH9KngMgca4
4G10JQj4NepR0WOxCIaYk/iu3kT7/cMwg9nm/oHq5iUWwiAxA2jhWKZZGKZsLEw4yCdV9hGg
wDKYzSbKvRRlNptmsYmkpFFLI3VduKn2JTYRPz0QOiDFDHpAl1kGYNrrG9bfIUweu8/gUd5E
VLGJdlexiZYv88tqOVebzpZJLRZBYdPZrhiojn9fAD/tjRmMaJ/BJIhHgRmgdoW29t2B/OzY
RAg6h5AU2ImM2mfTGdrI+agR7G60+wx86NnGFZvo9RJHaawPbNMui00ETOCgl3yWFkjMrwHz
0+X7DKLxWAYD2ylfFZuoDXZgBqt7dmwiBKk7IuhcHHjHJjrEoWqDYHXOQHVM+wxcsYnCABJz
o4I+7XbVsYmGppFOrWiQ96aHtqb8KHoSxMPHDMxne+dYUu2i4zaLTdQ0RhFCXNfFJHpkbCIo
sPuEbyFQXZPYRNF+Uxrcbjz7DDxot2XwpspOF7dlkMYagnUAvGAxBK+KJ61V81sEZV5FMZEX
UddRS+tjP2X7FMK83tVo8BmGkDB5WAk2jmAmrdl7XMfMZ2COoxCmu4PYRCpq6X6XMfUmUUuh
+Iaq3YYfM7Axg/U6DVa3XqX1bDoSzCCM+deU+Xci376vAHVji+CB71NFe2Q6E409rIglZNYo
WAryPR81zjXPL82B3PL7uAqFgUB129cEB0gjLXsFqtNtEKgO7fgxA8symGsrYGbVZkJ8wQxk
T8Fg8hk81TK4w05eh+bnXfNbCDdo6E0t0uhh71MWQK+kvaS9NLEB5QnkqeH71KZFgf/3Waaz
juZz98BAdVyYwa6QA9lk+mV0FrV0aPkMnpFR616YQQdr7koo9MJCGAaG0Do2UBA97H2qs0Ag
DFyYgG/Gsrra5ZGkfttXPN8W+TWWj4xaOhbMAF4+s6B4fGaaZpugwOx9yuzlpTQ2ET9mcH/M
oFNvnN55GfVwH0IXsYE6G89t0VGBGbhyG0vi+lstA9fmNWUpVFgGbTLuqbhEdxYEKlDdWDAD
uH1i0xl2IssOYNDYIZydq4WBj0WQC4NlaWwiAMkQDKBR1kaQuoX1Ipu0nC85DVTUUn7M4P5+
+n3GNIzc1JMn0Z1mpLvxeU098ifUWViwDFzae1eWAa5zdW30V4YZ3JCfYba9n0CYbQPVhyq6
PymTJ/7V/mGALgn2rTOdSVwixCpaZ6Eers/H9usXuJq+bZz1FJH8jPNRu/IZoF8zc1lqmaSx
iTAOnPd2+FCCSa6HayCwHgLWYbyF1Jwl421MjwQz6DQfAH9GuYfRmeUjjN03amlTjKfi/RDM
QDR4rO0rqyDqDjPAtQUzwP+VmMGN7x8shDmWuhPe1VVdZhFk31+f/9QgzYHrIhYBmCsY87zC
L3qeMHs8vKqyTMzLqYR21e3r8hmY/SHjGgLXwULB2FZG3CIsZ8EawFixjPVyj3wGY8EM8EJ2
Nb4u55ef7g1dtp9hk2jo4R6bz/ZZEdqsw4a0qzavrywDOw93i30afaD7LwwcEgyWAJjuz++f
kfHstxDWGudDGtYJglwgvBUsBFc+A+xIftm7NWIcx3iOmeafH4cwkFSdd9HQRrXPIH5cDl9+
mp/mp/PvrtfC4BaJ12LdbaGWjEQYXOczALP/PJ8NgZD3B5ygbF+CWAZ3k/Bj22dQov15FX4N
mp8eOh2kOCj4BuqFA1PBagSOzwwrRFYe8Pvc+D7nxu+FlYkxYAbpRKTLL7IMY+8UdqHym7d0
08Z286bq9dohDDxzINsSFhbBx9fZaQEoy+D8cz8JP7J9Bvw0P81MwzkF/AI4I1Y8PhQGmVvO
ahVCY5B7jVXONJaK304ao1zrHO1wrEkV2Z+EP/0W8q0MHjPABLwnQC4mSWrcKCYpO99hGSC+
B+J8xPFOhaV4e127LYOGmMFK51bAA8F4tsdT4XhmGdxLoxjTPgN+mp/mp1UNXmLvc4Ii/JMI
iLnj+0sdaY4FywK/QxhEWmignJCy1+HVOEjMQGhMFARDKhzOqZTUx12WAQLUqYBP+40SBq8u
YVCCGcAyQHJ7ZC5DDUkr+xrQrywP4SEUMq4F6RLSXbyIRokZ8NP8ND891Yqlvc9pf/rUfC52
rkDAklhY+2y2liLrStk7eMxAAsqhYAknNnIUuywDCAMIAUQv3W1fyy0DB2bQa42CPzYRP81P
j47OLAPjOFZB1jYjN46DF2b4pD4OYfCl3drhBAOBYR4fNGYgCfDFq0hqJUUrMAMV8OltfXl7
w+7BdYllECuwGBPGH5uIHzPgp/npZ9FFyyBfIk+xy/L2UIoPhlcjhAGEiCjOs5Kd0YPEDLzo
G7yJrqKW9l2j4McM+Gl+mgMzCGK1RL0Ir78/icAwUxtyz5lVYWMGo9pnkLpyHgo5kK/yGWAZ
qWHu0znyJgfpZKbXj3PXrb5n2DI2vDyq5tfg+Gl+unsay0BYmfjV2CTW+GfGceCXOIbVEPEm
QnucJ/uu4G0kggTWRZidN7J9Blgmwo1LKZN4WCryFQgIWcGvkfDT/DQ/3Yd9BlBEoZDCe2hu
B/FT2n+U/260nytF1gra6dn/IDED5csvptT32dpIYVsI9QKhIAj4NRR+mp/mpwnpQccmUpu9
knW1gs+sSwJq76KZij+ka4Pm10j4aX6an2anB4kZnHUsIgiFP71LD0UBKPwSnp/mp/lpfpo/
NhE/zU/z0/w0Px1xYAb8ND/NT/PT/DQ/ZuBF2xmdekE/TQOIjcQxcR7m2Yfm32nMT/PT/JhB
32MTVdJ9yjV7Q07UXuQH6FlOYX6an+an+TEDf7omZ+oz6GdkQOKPRcRP89P8NDdmEMa9swzS
GEJWirywJGVeJ9FMI/5YRPw0P81Pc2MGuEkwsbw8m44vaS2l4ngQ9y+ncBAPNGdu3M3989P8
9DPoIObHDLwxAz1x7vow3DroSOL3bTyPpof+HvDX1HWmhAX8mMHj1sR7Rk870ggmXeQ7COLB
rolOAn4Nk58eMP1Ai3z4mMGINYPOvYoCD8zCpoOBr4nya5j89aBrfszAGzPg1wj46er3gx8z
4Kf5MQMizGBsGgF/vgB+zIC/5q/5MYPRYgZ+O3/5NXp+zICf5qf5MYNxYwYBv8bPjxnw1/w1
P2bAjxkM2CuHHzPgp/lpfsyAHzMIhxybiB8z4Ncw+Wt+zIAfM+gXZhDE/Bo7P2bAT/PT/JgB
O2aQhsjQPvwl9V0kfpBuPJuW7tR211kbfsyAv+av+TEDfszgGV5HcYexeaJuvKD4MQN+mp/m
xwz4MQP+2ESTkB8z4K/5a37MgB8zGKhGEHc4vpgfM+Cn+Wl+zIAfMxhkbCL+fAb8GiZ/zY8Z
8GMGQ9cIehbPP+DHDPhpfpofM+DHDB5rEXQamyi+Pb/DkHdO82uY/DU/ZsCPGfQ3NpFmrk76
Xhm/okJoau/Cv8+An+an+TEDfsyAPzYRf2wi/pq/5scM+DED/thE/LGJ+Gl+mh8z4McM+GMT
oY503ZAOYl1Hz6X5NUz+mh8z8KL5MQP+2ESjpvkxA36aHzPwo/kxg0d7CYlQMEDjAt1XDXuo
NL+GyV/zYwZeND9m0NPYRBN+Db8Tmh8z4Kf5MQM/mh8zGHtsInaaX8Pkr/kxA37MYMj09IEa
AT9mwE/z0/yYwSgwg+Lae17Txybip/k1TP6aHzNgwQxK6YA/NhE/zY8Z8NP8mAEPZjBCjZDf
q4gfM+Cv+Wt+zKAhZlBKB3F/YxNJMVNdCs2v0fNjBvw0P82PGbTADEo1wpg/NhE/za9h8tf8
mAE9ZkBAF7Xex2swVy8WP2bAT/PT/JhB7zADAnryZK+pgvsrP2bAX/PX/JhBLzEDCjp++k5p
fsyAn+an+TGDfmMGBHQ/LAN+zIC/5q/5MQN+zIAfM+DHDPhpfpofM+DHDPgxA37MgL/mr/kx
A37MgB8z4McM+Gl+mh8zaMzaL23K9GXJbxHwYwYd0Pw1fz3kelSYQTthMJlO+C0AfsyAn+an
+enxYAZthUFS3naX6SbQ9W409HS758cM+Gl+mp/uBwbZe2Ew5vK65ccMdkYZMD3dRfy0g577
rnkn/79/fV8WErqdf/4eTvMLg6cKg82FHzPgp8dKv8bvl/jzy/P8+BK+n3JhwD9/D6f5hUEf
LIOWEp0fM+Cjl/tDRoNxzoylupd9zkiX+0Ohzcy8RnT06m+mGXT48ZlfW7eHxv92eFfHzWMo
2+OH+h31AcJAX28dH7Prv+z12DWNa+2TfuZh0a9+jb6S33bJtYLkmub94v/N4eNqfHXziXnD
9dAfBNbUmhtcD8euBNPI3y9+YfB0y6C9ROfHDPjon9+/jAbDAsMFDaZmMt6vn5+MscanL8U0
hRF+nn/8+kv+3yTX3yVM+Pz7mx5LChg9xnH6PivGiVraY0zHZLkneP9U5xw+v9XvGMv3z092
ffwOAZALind1HfWbMZ6P5DdcB/dwTNqgPzmOfmB57I7p+BTzrpk/nHP++c3mLhOMWrB8J8dw
vW1S5mTvN78wGDpm8MQyDfgxg0fTPwnTgxYMpggGKcwTGjTW3MHgVsn/YLyieUfJeamW/q2s
BMW8jevjNxyfWc8TzBECBkwYDFk0ZfSN36T9Kso1fgga0dJxTYwx1eKjVKDsRBhg7B+F/jA+
palbOEJ2j8mxoxYuBcGoxwShZY8/s0b09UJDgNrzmwlQfsyAXxgMDTPgp/loMEAscYDpQjMW
5gkNF0w+1cpPBQsCDBBFtU2OgcGa1wdj/vfvX8rULQ0aDBXM+KyFkFwvY7zW+L5EGAQiTL6z
836UdZGe//6lrQCjfSog3gvXg2WQjisVOh+GIFP3aFgk0OjN6/0l9wRN37xeZk055hdjZ8Ys
+IXBgDEDfvox9E6vm/dhPGCYf39/SvMHM5wF+XEwbDC/3+T4x9c5awMmmrb5VbVimuYaesK8
IVQyXCFI1+PPaskkWVs/faprLvfHXAs/fjjHF2bLRKdseccUFPgdQgvXMxk/xng6nxMrBmv1
uXYOwbXWlkcmDPT1YCXg+ng+mA+bkcMqUGMOTLwgVvMUaEzDxGCwJAbrIF0m+sitBH7MgF8Y
9B0z4KcfQ4OxBpkm/NzxgOGBiUL7NtfccRzLKLAQwNiFcctxMDgw+J0CYf36A/MVjTsDWoN0
DGUaNPpQALIGdTMgO/kd/wtoi/GZYPFGA7p7AYP19ZbaKhB6HeeYAu5DwGr7fqvuDwIBzxOC
x8Yo5J6xtPayP/BjBvzC4DFl+rZN1t7NB8KvkfeRhjYKrRZLM9Bqzdpe4+afL36aHzPgFwbN
SyIMCt45Ib/ffh9pWAbQqKGlQnM06xn//PDT/JgBvzC4XRjs3H78/F46vaJhGWQeOPzzwU/z
Ywb8wuDelsGVHz+/xtIPWgOq/PPBT/NjBvzC4I6WAX/sH36an+an+TEDfsugbqcvv8bydLoQ
csE4DpfHzE2Tf7746R7QtYnC+DGDgWEGBTrm12B6gBmso+PV8WyHLf988dNPplulEubHDAZm
GWRJsR+RU7kY8ygLkd236KTGOCVgXmGcQff7DMSFFDF33uJ056wSBllUTn4NlZ8ehhcQP2Yw
QMwgo+8YHTQTAIYlUpeTVZUHa0BqnGHcIKexMc4O9hlgOQjWAXa9YlOS2px0+sxi7/BrqPz0
ULyA+DGDAVsG0/Ae0RO1Vj2EfAadjrN5/3sdmVNcTM16986PGfDT/cMIarkxP2YwRMzAcDPt
QsNG3Wl+g/gu+yImmcDiz78g4R+yHAC+7YP666E2Y/CYv896Ol87lQSnGF0UFpuEDJH8B+bx
Fx2ZtRC7SIfuKOsPfcDyc+V/UMeSJUIoBYVd6CXjR9gLc+e6aVFCqchDjMf5OH2+57bcmB8z
GChm0NHO5HSp5Y75DbrEBO4+zmbjuwpalhyfV1hsYKSyU1mYEWiXV1IdjcBqXz+/iongf8U4
jFhACOaGIHRm0DUwxjSKZ0qfVETOdLxgSN/6egizActH3U9SEL0Uwdok4N3KiPffB40Y94tx
5XkN8iB9aeC+NAYS7sE8Duab5WTQ18Mc7Y38CHZ/mJ802utvQTDOjWB3K9mF7vH+LFVo8d8s
tpQcx/1IeG8IFhVk0HM+2lsG/JjBIDGDLjTafK39njmRDzev0aP9QzK2NRifRNo0GT0ic+Ij
3pZE7/zUsYzAbHEeGIowczP+v0//aCOJVlYqb0Eexnmns4lBQHwYu6RDK9Lql5Fn4NMIM232
p5jcz28hAum+J9FaTXdeSaxjHgeTxf1vD2kk0jSBj3k8jfJqZkQrCAOrv1edbEfyLCirw4iW
qua2xfgxruW+qDipKLM6sc/aCtPdlReRj1cRvzAYjDfRcDKi9dUiaGshqDDKRt6A74TxgIlA
EGCpAL+b56P+ST5wocEAVkk70GAs+Ojt86toJQzC9HdcRzELfRzHFriX5DyMa6n7AbNCQTTQ
RZgeU4wwOQ9MLo/ymfcHgfOXWAY4jjGDScl9W+O7TJ9EI5qoZFozNXLMAxg4LAJlGSTjl/a4
bxzHM4M3mFxPCYPTp7O/oyTVCVKN/lNfTywTeR5Nxy/jM4/jesoi+D4bloHf9fgxAzbMQB6Y
lCDyprvHCDzoFuPNx/nAHM5h7DU+fKRgwptE6xSmg9+VMCjZZ6ASuWgajEQx4h2EwXWGr7r+
0Sf6QcFYwOTxO5j8l5FKMtYZzUCLZSBMzbYMwICUUDH6A4PDuPE7rjX3nJ9H0oqZRqlXVzaP
Qar5Yz4+z2c1B8K8UcD0cT/Ib2AK0swycPSH8NZqLndp2GzJDzFTz/ZP/Y9lOPQTWBnWqsaP
88381Ch4FqghsGHpZc/F5/vmxwzIvIlu0ajCJ+VIbjreJ41z4qHhgYHjIzYZKjREfLRlGb9y
yyBd2pA159wy8J8fCANJxpJr6nHGQGAZ4Pr4XxgNBAHKu86GllsGKWYgFoTZHywDMLpUKPxd
abDPtAhA4z5huWBsYKBmzufUQkrzGOM5mZgBnhPOR7u/v3+ZRVGFGWB+0pzN6XPeaMEz03OE
3/E/5jhVCPzu50uEgXFcCYMgVsIFz6kJZtBGoy+7Hr8w6HVsotvW4GVT1uTBGnfGZH3HG0RP
GN/hepwl48NHj41mdo7gjDE77u/FZKTGcTCspl46YHTzwD2fYCAQMBsLMxBGJzmEzUxgmaVi
XQ9CQDADWXLpi0WgNHGt4WdjNawvEYpKEP+m+AzaZ5p8kF5PWUr6uWGOMGeoM8Dd6A/nfiQl
szIC6etHWV5og2NiQVSNHwIA52N+s6Q6QdEyEEFjW2xdWgiV/IJfGPTYMjDWRJtrVPFzLII2
41dLNs8b59RktD3QgG0aDGcWuC0Y8SYC434xNE4sa4EpnnX5NNbQYRngNzBQ1GBOKeOMC4xP
pZTsUewlMNRFZimnaS3luGkxQZCJxYZ7UqFEglxIpxhLOkfADCA0UcL305WgBuZiphYVDCLU
bTZ6Wa5u/KovtNH9bY+5RZneh+4vEerKCmkxP20tAn7MoMeYQcpIb9Oo/Hfq3peu1Wgyq+DJ
462Yz5Va5rk+Du20zAKA5hd+pOvOsxswn1voWZCmhszW/g0LAGWhy7PGx0/fhy4Fi2va8wuD
HloGqaZxo0b1TIvAiR24x5sJjaePt3w+zdhE5vGiN1GxPcBNLAtgqQGmP5ZyVoaG2kcLhJ/m
pvmFQQ8wA4m5M+1KQ3vyGnyBNu+pxxbMJCjHOLCGK6Y8lhwERM68iTw0dJyLJRkAiAsPi4mf
5qefbVHwC4NHltfNfSR8EPfHMrAZnzneIOrhOK/n07QMIsN9s2qfgbmUJK6OAB6Vn3vAr5Hy
0/2j+YXBU4XB9j4S/qleRK59EiVrlEHcHwsmdIDdxj4DgK1fehfrj9bwf7T/v+v+8Ht6/q/y
iV+JK6fj+nBjzDxaDBATgKkJXq5sd1CHRbjRy1OzGousCQ2BJuOzvW7SMcaFe+nifZ5pTynp
U3nfeFhgcn7Bl7+iv5nefCYF8+eDoUDAm/Mx88D4XvYNY0s5xrfcH+5mIfALg6dbBneQ+L20
DPpvwZTt9Bag2FXKdqJKm1lQv49BNi/J3gDxgz/KngRjp2qVBQLhA88ieKssqiyyEr968Sqq
Gx+Wu0QwnfSGvKkGq82d17e8zzsdAsTscxFW73uYa7//k3IX/fTqTwSI9AMhnwaviystWrPN
6dsvei32RYgbahY3qmZ8eK547tJXrhDwYwbjtAy6XgMMh6Fx982CmTzJq2ZXshP2YAiDWZD7
o7uuJ3kWXBq28ihK7q1gnYig078DE4EgKRuf7EgW91MVziI5LpvaXL7/t8yPHTdIbZSzdu6W
tU/DTpxa9Y/73Bw+Go3Xtz/ZD5LtHQljDwvJmFN+zIAfM2gs4cNhaNzTXloG1/MJJoSlIjA+
AY/xe6iXFVzPAwxCdi0DZ5B4P6jnYXE+oCUeNVM1l4JwbQlKB40S57h35sZZiIQyDRsMBTUY
khxHf2cdfgLt30uuD0Eh+xXSXbx5NFNcX3YCp/9/d/I+56Ei4mIYB4/2GXP27A+CDUJXgtP5
xo7C3gYJ9bHJNp5V72QXy0Dt9PbYhyO7wdHP2tz4yI8Z8GMGXnRPLIK62Ep9wwzKMsodtNYN
po6lFAgExMABcy5bAwZWAOYFpinhJECnsYKKsYnAhPA7mPH5Nw8pke5ITTXI07fDvdVoL7Fz
IEAwVrkGBA2Yvew5UDuMxUvq65xtyML4Msug5v06GfF1ZNcsri1xg7p4n4uhIizLoKa9CINs
f0jF+XiWmGMwalhXeL4+mMFML/ugza8hHKvGh/NlGQ9tlnUYkLYI0eaod0KXxVLixwz4MYNh
YAbBsDED8SaCdiYa8lUIAuv+fo3YRGYsoLrYRGmE1HxnrQSou1oqsDRUCWEAQaPWsDXIu5NQ
1vp804KQAHwiUFLLoP79OhntROOFV9XX+aez9xlr/ibjyy2D+vYSndRcwio7v2n+ABcNAeKD
UaAvAYKVMGgY+wnvzTET2PyYAT9m4LXPoGeYQel440FYMBKobKdjy4BZA8x8qVjDVlFLs7DL
n9nSEBi7GW1TXE9f9PU+RBjo4/gNCWfCijVpCdmsQO3woBinZPBCFMzQ0LDNaKqxDgeNdie9
DObzfqVaem4BwLrAGHcNonf6YAYYn8yzK9pnWewntINAUPtDajR2HMf9SD+L0M8La6EdBNAO
/TXFKHwxA5WfIUrft2xJjh8z4McM+PcZPMfrCR+7uJbade7tU7y/6OTemYyYNKZGONPXBzMH
wwNGMLMslKJ3UFyLUeB6MyMmjhmbx4zfD2Ykyw/iVln3fs30vgt7PFmfHb3PSy2gMMcyL3U7
8zEmmce0PhsYj7u/lc5VYLar81qaaevoU0dHzYRjg/vLrJ6a86EoqHnQeNPrnfJLTB77x8/8
H4YZBFF/NO4av2ozymmfd0rz0/w0/85jfmEwPMyAPzZRp7GJ+Gl+eqz05Dl//Mz/YZjB7jE5
j13RVmWZahL4Zzh7OIZRNk5+jZGfJqP5hcHIMQNzqeghfvm3xtq5M8YhfUxaRIOdWR9Qb+iB
jK9v8z0d6/Pp974CfmHwTMygOz/+PKrqJLhXTty4s5zGIqAmt8bG2YaX1WrVqCzX68Zt2pZl
mzYtxtemzXwbpPMoJYhq6fnbVrVtUpavr43bvKybt1muXy+om5RHzfVytVbzp+ZRigc9ee5f
S4Y5nVymyYc53e7zeqeL/Tvq5PeJ+v/6dzUR25J2ZXWgk7V3VE/McZsP6l4WQhMN2hVO+97j
E7oRdhA7dgx3O55Z8pwe8TGvVm3a9LsoYdBwvheb3WWdzF+TAsbetM3y9a15m1b9tGjT8HyU
VVKavt+T5/+116CvJJwN9u0iw50yzoFLSyJma8RNJGgwbK8V15p8b9fMw9iR8c2wSh4YO8i0
DJbL5eXl5aW04LgtDLzbmMLEs82q520yy6DBfC8SyyBjism1qgr6sBm7bxtTgHj306rN+jFt
VushWQQ3iI8yCWfvFA0ir1gzEhitmcZ6L++aB2ncmuFPWq6ZP8VCuKPG70vPtnsnI1wsFkm9
0HXKBNdaCJQJg6o2qzZtSph0X9qklkGz+RbLQK5RJnSECZqMvUkbESCN2rTpp1WbdeM2uWUw
CIvgRmFwZQFEV9Ely6JfXm94ipwWQxXdtVdOLzRwfrqWti0DlNlspstU1fP5vPDx2sLAp43N
cMfQpi1mkAnVq77SAuHjWopp0sYUIN79tGqzfkwbT8xgMvQ/t4SLnRp/6Rq4pSFPa3ZyOvvr
yqvFGk+vNXRy2sQM5MO0ly/xca7ND9ghDOramJiBf5tVr9vcghn49lXG2OvamJaBd5tW/bRo
4xAGdW18MIPJGP7K1sCvNwiV7GR1WRBt1uw7yg8wfVK8fH76dsyg6sOssgxq2zRguFUae5/a
3IIZ3JuxtxIg68cw9lZtajCDyVj+SiWeU8MuxvGfuDJQtfWSCaIOd7jya+BDoG3M4G6WwXqs
lkF7zGAUlsH60ZbBSC2CKsygrYY/KfFC8vcqim7amTvh17gHjxncwzJYjdkyuBEzuMdSzCgt
gzFbBNWYgeHlEzT0Cgpu9cqJO43nz08PBzNA/ZowH7tUWQY+bWzMwK/NqtdtusAMyvoy+7MZ
u08b2zLwatOqnxZtLGHg06YMMxifMKjy8jEZvIdFMGnoRVR7PY+duxN+jGAUmAHK29tbaXEJ
A+82FtP1abPqeZtbMQPUm83GWaQvm7H7tjEFiHc/rdqsH9OmBDMYqWVQr/EX9h7YXkdVOXhv
ol2Wwv13xvLTj8cMzA+0qjaFgW+bVZs2Ruljm1sxg6Y7kJu0sQVIkx3I92+zbtymDDMYpzDw
0jDiDFg2GfL9YumUWAz8GvUoMYP7hqNYjTMcRUvM4N4hH1qFsFg/JrREqzb8mAE/zU/fmy5+
YLOx0MHI7of9/kveXyrMgJ/mp/lpfpqfjvgxA36an+an+Wl+OubHDPhpfpqf5qf56e52Hv8H
YM4nkV8V9NwAAAAASUVORK5CYII='! !

!ArduinoMorph class methodsFor: 'initialize'!
initialize
	super initialize.
	Vocabulary addStandardVocabulary: (SymbolListType new vocabularyName: #ArduinoPinMode;
			 symbols: #(#input #output )).
	Vocabulary addStandardVocabulary: (SymbolListType new vocabularyName: #ArduinoType;
			 symbols: #(#bluetooth #'diecimila w/ atmega168' #'duemilanove w/ atmega168' #'duemilanove w/ atmega328' #'lilypad w/ atmega168' #'lilypad w/ atmega328' #mega #mini #'nano w/ atmega168' #'nano w/ atmega328' #'ng or older w/ atmega168' #'ng or older w/ atmega8' #'pro mini w/ atmega168' #'pro mini w/ atmega328' #'pro w/ atmega168' #'pro w/ atmega328' ))! !

!ArduinoMorph class methodsFor: 'accessing'!
lastBoardType
	^ lastBoardType
		ifNil: [lastBoardType := #'duemilanove w/ atmega328']! !

!ArduinoMorph class methodsFor: 'accessing'!
lastBoardType: t1 
	lastBoardType := t1! !

!ArduinoMorph class methodsFor: 'accessing'!
lastPortName
	^ lastPortName
		ifNil: [lastPortName := #com1]! !

!ArduinoMorph class methodsFor: 'accessing'!
lastPortName: t1 
	lastPortName := t1! !


!ArduinoPinMorph methodsFor: 'attaching'!
attachNewDevice
	| t1 |
	t1 := self newDevice.
	t1 isNil
		ifTrue: [form := self class form.
			self changed.
			^ self].
	t1 center: self center.
	t1 openInWorld.
	self attach: t1! !

!ArduinoPinMorph methodsFor: 'attaching'!
attach: t1 
	t1 class newConnectorFromMorph: attachmentPoint toMorph: t1 attachmentPoint.
	t1 attach: pin.
	t1 center: self center + (-68 @ -100)! !

!ArduinoPinMorph methodsFor: 'attaching'!
connectedToBy: t1 
	| t2 |
	t1 connectFinishTo: attachmentPoint.
	t1 startControllingConnections.
	t2 := t1 sourceMorph owner.
	t2 attach: pin! !

!ArduinoPinMorph methodsFor: 'attaching'!
disconnectedFromBy: t1 
	[t1 destinationMorph
		ifNotNilDo: [:t2 | t2 owner detach].
	t1 sourceMorph
		ifNotNilDo: [:t2 | t2 owner detach]]
		on: Error
		do: []! !

!ArduinoPinMorph methodsFor: 'attaching'!
newDevice
	| t1 t2 t3 |
	t1 := self class devices
				asSortedCollection: [:t4 :t5 | t4 asString <= t5 asString].
	t1 size = 1
		ifTrue: [^ t1 first new].
	t2 := t1
				collect: [:t6 | '  ' , t6 defaultNameStemForInstances , '  '].
	t3 := PopUpMenu withCaption: 'Device:' chooseFrom: t2.
	t3 = 0
		ifTrue: [^ nil].
	^ (t1 at: t3) new! !

!ArduinoPinMorph methodsFor: 'testing'!
canBeAttachedTo: t1 
	self class devices
		do: [:t2 | 
			(t1 isKindOf: t2)
				ifTrue: [^ true].
			nil].
	^ false! !

!ArduinoPinMorph methodsFor: 'drawing'!
drawOn: t1 
	t1 drawImage: form at: self bounds topLeft! !

!ArduinoPinMorph methodsFor: 'initialization'!
initialize
	super initialize.
	form := self class form.
	self extent: self class form extent.
	self initializeAttachmentPoint! !

!ArduinoPinMorph methodsFor: 'initialization'!
initializeAttachmentPoint
	attachmentPoint := PEAttachmentPointMorph new color: Color transparent;
				 borderWidth: 0;
				 extent: 1 @ 1;
				 center: self center + (1 @ 0).
	self addMorph: attachmentPoint! !

!ArduinoPinMorph methodsFor: 'initialization'!
initializeEventHandling
	self
		on: #mouseEnter
		send: #mouseEnter:forMorph:
		to: self;
		
		on: #mouseLeave
		send: #mouseLeave:forMorph:
		to: self.
	self
		on: #mouseDown
		send: #mouseDown:forMorph:
		to: self! !

!ArduinoPinMorph methodsFor: 'event handling'!
mouseDown: t1 forMorph: t2 
	self attachNewDevice! !

!ArduinoPinMorph methodsFor: 'event handling'!
mouseEnter: t1 forMorph: t2 
	form := self class form deepCopy reverse.
	self changed! !

!ArduinoPinMorph methodsFor: 'event handling'!
mouseLeave: t1 forMorph: t2 
	form := self class form.
	self changed! !

!ArduinoPinMorph methodsFor: 'private'!
setPin: t1 
	pin := t1! !

!ArduinoPinMorph methodsFor: 'as yet unclassified'!
wantsAttachmentFromEnd: t1 ofConnector: t2 
	owner
		ifNil: [^ false].
	self == t2
		ifTrue: [^ false].
	self isConnectable
		ifFalse: [^ false].
	(self
		firstOwnerSuchThat: [:t3 | t3 == t2])
		ifNotNil: [^ false].
	(self isConstrainedBy: t2)
		ifTrue: [^ false].
	self isPartsDonor
		ifTrue: [^ false].
	(false
			and: [self topRendererOrSelf owner isPlayfieldLike not])
		ifTrue: [^ false].
	t2 pasteUpMorphOrWorld
		ifNotNilDo: [:t4 | 
			(t4 isPartsBin not
					and: [t4 ~= World
							and: [self pasteUpMorphOrWorld ~~ t4]])
				ifTrue: [^ false].
			nil].
	^ true! !


!ArduinoPinMorph class methodsFor: 'as yet unclassified'!
devices
	^ self subclassResponsibility! !

!ArduinoPinMorph class methodsFor: 'form'!
form
	^ form
		ifNil: [form := Form
						extent: 12 @ 12
						depth: 32
						fromArray: #(4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4281742902 4281479730 4281479730 4281479730 4281479730 4281479730 4281479730 4281479730 4282203453 4282400832 4282400832 4282335039 4281874488 4281282350 4280953385 4280953385 4280953385 4280953385 4280953385 4282137660 4282729797 4282400832 4282400832 4282335039 4281808695 4281742902 4279703318 4279703318 4279703318 4279703318 4280492835 4282861383 4282729797 4282400832 4282400832 4282335039 4281808695 4281742902 4278190081 4278190081 4278190081 4278190081 4279703319 4282861383 4282729797 4282400832 4282400832 4282335039 4281808695 4281742902 4278190081 4278190081 4278190081 4278190081 4279703319 4282861383 4282729797 4282400832 4282400832 4282335039 4281808695 4281742902 4278190081 4278190081 4278190081 4278190081 4279703319 4282861383 4282729797 4282400832 4282400832 4282335039 4281808695 4281742902 4278190081 4278190081 4278190081 4278190081 4279703319 4282861383 4282729797 4282400832 4282400832 4282335039 4281808695 4282335039 4283256141 4283256141 4283256141 4283256141 4283256141 4282992969 4282729797 4282400832 4282400832 4282335039 4282400832 4284045657 4284045657 4284045657 4284045657 4284045657 4284045657 4283848278 4282861383 4282400832 4282400832 4282335039 4282664004 4282664004 4282664004 4282664004 4282664004 4282664004 4282664004 4282664004 4282532418 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 4282400832 )
						offset: 0 @ 0]! !

!ArduinoPinMorph class methodsFor: 'instance creation'!
justASketch
	^ SketchMorph withForm: self form! !

!ArduinoPinMorph class methodsFor: 'instance creation'!
on: t1 
	^ self new initializeEventHandling setPin: t1! !


!ArduinoAnalogPinMorph class methodsFor: 'as yet unclassified'!
devices
	^ AttachableDeviceMorph analogSubclasses! !


!ArduinoDigitalPinMorph class methodsFor: 'as yet unclassified'!
devices
	^ AttachableDeviceMorph digitalSubclasses! !


!ArduinoPlayer methodsFor: 'commands'!
connect
	^ self costume renderedMorph connect! !

!ArduinoPlayer methodsFor: 'commands'!
disconnect
	^ self costume renderedMorph disconnect! !

!ArduinoPlayer methodsFor: 'slots'!
getAnalogPin0
	^ self costume renderedMorph analogPin0! !

!ArduinoPlayer methodsFor: 'slots'!
getAnalogPin1
	^ self costume renderedMorph analogPin1! !

!ArduinoPlayer methodsFor: 'slots'!
getAnalogPin2
	^ self costume renderedMorph analogPin2! !

!ArduinoPlayer methodsFor: 'slots'!
getAnalogPin3
	^ self costume renderedMorph analogPin3! !

!ArduinoPlayer methodsFor: 'slots'!
getAnalogPin4
	^ self costume renderedMorph analogPin4! !

!ArduinoPlayer methodsFor: 'slots'!
getAnalogPin5
	^ self costume renderedMorph analogPin5! !

!ArduinoPlayer methodsFor: 'slots'!
getBoardType
	^ self costume renderedMorph boardType! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin10
	^ self costume renderedMorph digitalPin10! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin10Mode
	^ self costume renderedMorph digitalPin10Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin11
	^ self costume renderedMorph digitalPin11! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin11Mode
	^ self costume renderedMorph digitalPin11Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin12
	^ self costume renderedMorph digitalPin12! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin12Mode
	^ self costume renderedMorph digitalPin12Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin13
	^ self costume renderedMorph digitalPin13! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin13Mode
	^ self costume renderedMorph digitalPin13Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin14
	^ self costume renderedMorph getDigitalPin14! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin2
	^ self costume renderedMorph digitalPin2! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin2Mode
	^ self costume renderedMorph digitalPin2Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin3
	^ self costume renderedMorph digitalPin3! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin3Mode
	^ self costume renderedMorph digitalPin3Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin4
	^ self costume renderedMorph digitalPin4! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin4Mode
	^ self costume renderedMorph digitalPin4Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin5
	^ self costume renderedMorph digitalPin5! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin5Mode
	^ self costume renderedMorph digitalPin5Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin6
	^ self costume renderedMorph digitalPin6! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin6Mode
	^ self costume renderedMorph digitalPin6Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin7
	^ self costume renderedMorph digitalPin7! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin7Mode
	^ self costume renderedMorph digitalPin7Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin8
	^ self costume renderedMorph digitalPin8! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin8Mode
	^ self costume renderedMorph digitalPin8Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin9
	^ self costume renderedMorph digitalPin9! !

!ArduinoPlayer methodsFor: 'slots'!
getDigitalPin9Mode
	^ self costume renderedMorph digitalPin9Mode! !

!ArduinoPlayer methodsFor: 'slots'!
getIsAnalogPin0Active
	^ self costume renderedMorph isAnalogPin0Active! !

!ArduinoPlayer methodsFor: 'slots'!
getIsAnalogPin1Active
	^ self costume renderedMorph isAnalogPin1Active! !

!ArduinoPlayer methodsFor: 'slots'!
getIsAnalogPin2Active
	^ self costume renderedMorph isAnalogPin2Active! !

!ArduinoPlayer methodsFor: 'slots'!
getIsAnalogPin3Active
	^ self costume renderedMorph isAnalogPin3Active! !

!ArduinoPlayer methodsFor: 'slots'!
getIsAnalogPin4Active
	^ self costume renderedMorph isAnalogPin4Active! !

!ArduinoPlayer methodsFor: 'slots'!
getIsAnalogPin5Active
	^ self costume renderedMorph isAnalogPin5Active! !

!ArduinoPlayer methodsFor: 'slots'!
getIsConnected
	^ self costume renderedMorph isConnected! !

!ArduinoPlayer methodsFor: 'slots'!
getPortName
	^ self costume renderedMorph portName! !

!ArduinoPlayer methodsFor: 'slots'!
setBoardType: t1 
	^ self costume renderedMorph boardType: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin10Mode: t1 
	^ self costume renderedMorph digitalPin10Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin10: t1 
	^ self costume renderedMorph digitalPin10: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin11Mode: t1 
	^ self costume renderedMorph digitalPin11Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin11: t1 
	^ self costume renderedMorph digitalPin11: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin12Mode: t1 
	^ self costume renderedMorph digitalPin12Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin12: t1 
	^ self costume renderedMorph digitalPin12: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin13Mode: t1 
	^ self costume renderedMorph digitalPin13Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin13: t1 
	^ self costume renderedMorph digitalPin13: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin2Mode: t1 
	^ self costume renderedMorph digitalPin2Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin2: t1 
	^ self costume renderedMorph digitalPin2: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin3Mode: t1 
	^ self costume renderedMorph digitalPin3Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin3: t1 
	^ self costume renderedMorph digitalPin3: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin4Mode: t1 
	^ self costume renderedMorph digitalPin4Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin4: t1 
	^ self costume renderedMorph digitalPin4: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin5Mode: t1 
	^ self costume renderedMorph digitalPin5Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin5: t1 
	^ self costume renderedMorph digitalPin5: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin6Mode: t1 
	^ self costume renderedMorph digitalPin6Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin6: t1 
	^ self costume renderedMorph digitalPin6: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin7Mode: t1 
	^ self costume renderedMorph digitalPin7Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin7: t1 
	^ self costume renderedMorph digitalPin7: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin8Mode: t1 
	^ self costume renderedMorph digitalPin8Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin8: t1 
	^ self costume renderedMorph digitalPin8: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin9Mode: t1 
	^ self costume renderedMorph digitalPin9Mode: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setDigitalPin9: t1 
	^ self costume renderedMorph digitalPin9: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setIsAnalogPin0Active: t1 
	^ self costume renderedMorph isAnalogPin0Active: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setIsAnalogPin1Active: t1 
	^ self costume renderedMorph isAnalogPin1Active: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setIsAnalogPin2Active: t1 
	^ self costume renderedMorph isAnalogPin2Active: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setIsAnalogPin3Active: t1 
	^ self costume renderedMorph isAnalogPin3Active: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setIsAnalogPin4Active: t1 
	^ self costume renderedMorph isAnalogPin4Active: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setIsAnalogPin5Active: t1 
	^ self costume renderedMorph isAnalogPin5Active: t1! !

!ArduinoPlayer methodsFor: 'slots'!
setPortName: t1 
	^ self costume renderedMorph portName: t1! !


!ArduinoPlayer class methodsFor: 'as yet unclassified'!
isUniClass
	^ self ~~ self officialClass! !

!ArduinoPlayer class methodsFor: 'as yet unclassified'!
officialClass
	^ ArduinoPlayer! !

!ArduinoPlayer class methodsFor: 'as yet unclassified'!
wantsChangeSetLogging
	^ (self == ArduinoPlayer
			or: [(self name beginsWith: 'ArduinoPlayer') not])
		or: [Preferences universalTiles]! !


!ArduinoWireMorph methodsFor: 'as yet unclassified'!
enterHandlingDrop
	| t1 t2 t3 t4 t7 t8 t11 t12 t13 |
	self log: #debug items: {'enterHandlingDrop'}.
	t1 := constraints
				select: [:t5 | t5 input isNil].
	t3 := t1
				collect: [:t6 | 
					t7 := self griddedPoint: t6 targetPoint.
					t8 := self connectionTargetsAt: t7 for: t6.
					t8 notEmpty
						ifTrue: [{true
								ifTrue: [t8 last]
								ifFalse: [t8 first]. t7}]
						ifFalse: [{nil. nil}]].
	self isWiring
		ifTrue: [t1 size = 2
				ifTrue: [t4 := t3
								findFirst: [:t9 | t9 first notNil].
					t4 = 0
						ifTrue: [t4 := 1].
					t2 := t1 atWrap: t4 + 1.
					t1 := t1 copyFrom: t4 to: t4.
					t3 := t3 copyFrom: t4 to: t4]].
	t1
		with: t3
		do: [:t6 :t10 | 
			t11 := t10 first.
			t7 := t10 second.
			t11 isNil
				ifTrue: [t6 connectToNothing; forceRedraw]
				ifFalse: [t6 attachTo: t11 at: t7]].
	self changed; layoutChanged.
	(self isWiring
			and: [t2 notNil])
		ifTrue: [t12 := ActiveHand lastEvent.
			t13 := self
						griddedPoint: (self globalPointToLocal: t12 position).
			t1 first lastTargetPoint: t13.
			t2 center: t13.
			self setProperty: #triggeredWireFinish toValue: t13.
			self trigger: #wireFinish withArguments: {t2. t12}]! !

!ArduinoWireMorph methodsFor: 'as yet unclassified'!
monitorDestinationForEnds
	| t1 t2 t4 |
	t1 := IdentitySet new.
	constraints
		do: [:t3 | 
			t4 := t3 input.
			(t4 isNil
					or: [t4 isHandMorph])
				ifTrue: [t2 := self
								connectionTargetsAt: (self visible
										ifTrue: [t3 center]
										ifFalse: [ActiveHand position])
								for: t3.
					t2 isEmpty
						ifFalse: [t1
								add: (true
										ifTrue: [t2 last]
										ifFalse: [t2 first])]]].
	self
		newCursor: (t1 isEmpty
				ifTrue: [Cursor crossHair]
				ifFalse: [Cursor webLink]).
	self
		valueOfProperty: #highlightedTargets
		ifPresentDo: [:t5 | (t5 difference: t1)
				do: [:t6 | t6 highlightForConnection: false]].
	t1
		do: [:t6 | t6 highlightedForConnection
				ifFalse: [t6 highlightForConnection: true]].
	self setProperty: #highlightedTargets toValue: t1.
	^ t1 isEmpty not! !

!ArduinoWireMorph methodsFor: 'as yet unclassified'!
wantsToAttachEnd: t1 toMorph: t2 
	(super wantsToAttachEnd: t1 toMorph: t2)
		ifFalse: [^ false].
	^ t2 canBeAttachedTo: self sourceMorph owner! !

!ArduinoWireMorph methodsFor: 'initialization'!
initialize
	super initialize.
	self beOrthogonal: false;
		 beSmoothCurve: true;
		 lineColor: Color red;
		 lineWidth: 4;
		 borderWidth: 1;
		 borderColor: Color gray;
		 yourself! !


!ArduinoWireMorph class methodsFor: 'as yet unclassified'!
validConnectionClasses
	^ super validConnectionClasses , {ArduinoPinMorph. AttachableDeviceMorph}! !


!AttachableDeviceMorph methodsFor: 'attaching'!
attach: t1 
	device attach: t1! !

!AttachableDeviceMorph methodsFor: 'attaching'!
detach
	self isAttached
		ifFalse: [^ self].
	[device detach]
		on: Error
		do: []! !

!AttachableDeviceMorph methodsFor: 'attaching'!
isAttached
	^ device isAttached! !

!AttachableDeviceMorph methodsFor: 'attachment point'!
attachmentPoint
	^ attachmentPoint! !

!AttachableDeviceMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color yellow! !

!AttachableDeviceMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center! !

!AttachableDeviceMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color blue! !

!AttachableDeviceMorph methodsFor: 'initialization'!
delete
	self detach.
	^ super delete! !

!AttachableDeviceMorph methodsFor: 'initialization'!
initialize
	super initialize.
	self extent: self class form extent.
	self initializeAttachmentPoint.
	device := self class device new! !

!AttachableDeviceMorph methodsFor: 'initialization'!
initializeAttachmentPoint
	attachmentPoint := PEAttachmentPointMorph new extent: 10 @ 10;
				 center: self attachmentPointCenter;
				 color: self attachmentPointColor;
				 borderColor: self attachmentPointBorderColor;
				
				on: #mouseDown
				send: #mouseDown:evt:
				to: self.
	self addMorph: attachmentPoint! !

!AttachableDeviceMorph methodsFor: 'initialization'!
newPlayerInstance
	^ AttachableDevicePlayer newUserInstance! !

!AttachableDeviceMorph methodsFor: 'as yet unclassified'!
disconnectedFromBy: t1 
	self detach! !

!AttachableDeviceMorph methodsFor: 'as yet unclassified'!
isConnectable
	^ false! !

!AttachableDeviceMorph methodsFor: 'as yet unclassified'!
moveTo: t1 
	| t2 t3 t4 t5 t6 t7 t8 t9 |
	t6 := self center x.
	t7 := self center y.
	t8 := self center - t1.
	t2 := t8 y abs.
	t3 := t8 x abs.
	t9 := 10.
	t4 := t2 / t9 * t8 y sign.
	t5 := t3 / t9 * t8 x sign.
	[t9
		timesRepeat: [t6 := t6 - t5.
			t7 := t7 - t4.
			self center: t6 rounded @ t7 rounded.
			(Delay forMilliseconds: 1) wait]]
		forkNamed: self class asString , ' moveTo: ' , t1 asString! !

!AttachableDeviceMorph methodsFor: 'drawing'!
drawOn: t1 
	t1 translucentImage: self class form at: self bounds topLeft! !

!AttachableDeviceMorph methodsFor: 'viewer category filter'!
filterViewerCategoryDictionary: t1 
	| t2 |
	super filterViewerCategoryDictionary: t1.
	t2 := self validCategories.
	t1 keys
		do: [:t3 | (t2 includes: t3)
				ifFalse: [t1 removeKey: t3]]! !

!AttachableDeviceMorph methodsFor: 'viewer category filter'!
validCategories
	^ self class additionsToViewerCategories
		collect: [:t1 | t1 first]! !

!AttachableDeviceMorph methodsFor: 'viewer category filter'!
wantsConnectionVocabulary
	^ false! !

!AttachableDeviceMorph methodsFor: 'viewer category filter'!
wantsConnectorVocabulary
	^ false! !

!AttachableDeviceMorph methodsFor: 'viewer category filter'!
wantsEmbeddingsVocabulary
	^ false! !

!AttachableDeviceMorph methodsFor: 'testing'!
isAnalog
	^ self class isAnalog! !

!AttachableDeviceMorph methodsFor: 'testing'!
isDigital
	^ self class isDigital! !

!AttachableDeviceMorph methodsFor: 'event handling'!
mouseDown: t1 evt: t2 
	self isAttached
		ifTrue: [^ self].
	self class newConnector startWiringFrom: attachmentPoint! !


!AttachableDeviceMorph class methodsFor: 'as yet unclassified'!
analogSubclasses
	^ (self allSubclasses
		select: [:t1 | t1 isAnalog]) asArray! !

!AttachableDeviceMorph class methodsFor: 'as yet unclassified'!
digitalSubclasses
	^ (self allSubclasses
		select: [:t1 | t1 isDigital]) asArray! !

!AttachableDeviceMorph class methodsFor: 'as yet unclassified'!
isAnalog
	^ false! !

!AttachableDeviceMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ false! !

!AttachableDeviceMorph class methodsFor: 'form'!
form
	^ form
		ifNil: [self initializeForm]! !

!AttachableDeviceMorph class methodsFor: 'form'!
initializeForm
	self subclassResponsibility! !

!AttachableDeviceMorph class methodsFor: 'connectors'!
newConnector
	^ self subclassResponsibility! !

!AttachableDeviceMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ self subclassResponsibility! !


!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getBuzzerValue
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getDegrees
	^ self costume renderedMorph angle! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getIsLedOn
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getIsOn
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getIsPressed
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getLedValue
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getLightValue
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getPotentiometerValue
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getTemperatureValue
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
getTiltValue
	^ self costume renderedMorph value! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
setBuzzerValue: t1 
	^ self costume renderedMorph value: t1! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
setDegrees: t1 
	^ self costume renderedMorph angle: t1! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
setIsLedOn: t1 
	^ self costume renderedMorph value: t1! !

!AttachableDevicePlayer methodsFor: 'as yet unclassified'!
setLedValue: t1 
	^ self costume renderedMorph value: t1! !


!AttachableDevicePlayer class methodsFor: 'as yet unclassified'!
isUniClass
	^ self ~~ self officialClass! !

!AttachableDevicePlayer class methodsFor: 'as yet unclassified'!
officialClass
	^ AttachableDevicePlayer! !

!AttachableDevicePlayer class methodsFor: 'as yet unclassified'!
wantsChangeSetLogging
	^ (self == self officialClass
			or: [(self name beginsWith: self officialClass asString) not])
		or: [Preferences universalTiles]! !


!BuzzerMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!BuzzerMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (9 @ 46)! !

!BuzzerMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color red! !

!BuzzerMorph methodsFor: 'value'!
value
	^ [device value]
		on: Error
		do: [-1]! !

!BuzzerMorph methodsFor: 'value'!
value: t1 
	[device value: t1]
		on: Error
		do: []! !


!BuzzerMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#servo #(#(#slot #buzzerValue '' #Number #readWrite #Player #getBuzzerValue #Player #setBuzzerValue:))) )! !

!BuzzerMorph class methodsFor: 'parts bin'!
defaultNameStemForInstances
	^ 'Buzzer'! !

!BuzzerMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Buzzer'
		categories: {'Electronics'}
		documentation: ''! !

!BuzzerMorph class methodsFor: 'as yet unclassified'!
device
	^ Buzzer! !

!BuzzerMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ true! !

!BuzzerMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: '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
4Ac/iPE/g+yDJO2U5kkAAAAASUVORK5CYII='! !

!BuzzerMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color red;
		 yourself! !

!BuzzerMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color red;
		 yourself! !


!EButtonMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!EButtonMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (13 @ 29)! !

!EButtonMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color red! !

!EButtonMorph methodsFor: 'accessing'!
value
	^ [device value = 1]
		on: Error
		do: [false]! !


!EButtonMorph class methodsFor: 'as yet unclassified'!
device
	^ EButton! !

!EButtonMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ false! !

!EButtonMorph class methodsFor: 'form'!
initializeForm
	self subclassResponsibility! !

!EButtonMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color red;
		 yourself! !

!EButtonMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color red;
		 yourself! !


!LightDiodeMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!LightDiodeMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (7 @ 35)! !

!LightDiodeMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color gray! !

!LightDiodeMorph methodsFor: 'value'!
value
	^ [device value = 1]
		on: Error
		do: [false]! !

!LightDiodeMorph methodsFor: 'value'!
value: t1 
	[device
		value: (t1
				ifTrue: [1]
				ifFalse: [0])]
		on: Error
		do: []! !


!LightDiodeMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#led #(#(#slot #isLedOn '' #Boolean #readWrite #Player #getIsLedOn #Player #setIsLedOn:))) )! !

!LightDiodeMorph class methodsFor: 'scripting'!
defaultNameStemForInstances
	^ 'Led'! !

!LightDiodeMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Led'
		categories: {'Electronics'}
		documentation: ''! !

!LightDiodeMorph class methodsFor: 'as yet unclassified'!
device
	^ LightEmittingDiode! !

!LightDiodeMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ true! !

!LightDiodeMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAACUAAABQCAYAAACecbxxAAAABHNCSVQFBQUBSsjp7wAABF9J
REFUeF7lmK+zozAUhSsrn1xZWVmJrEQikchKJBKJRCIjkZGRkcjK/VPWZXMSLk1ZaBt+tbNl
5k5K4L2cfDm5SdhNubjkqpCVuohcJSYylcpClZIp2Ui12/JCoyG/qBOP1dGJU+83hNZa+Kpi
hBQq1jRMoyIeLAORqFhmprT1iUpFoZqmWV4c14LOmk6fyNB9eWUmLk1hniHQmUWHVEipzuJy
67luDA2OEQv1u/m1UuXvWhVaHKihHp5bTJQ7ZFlTmsbKa60imT0kluLdqyNM1xWimi+MyboT
BEIVBLUBGmPeohL+AuVT6zGIk3LmMEYiNT3EPyZCKEHhNELo2X0uSzVrtlGPs9YjN0LJQ0KP
SnhuVj4icxMh66V0EiGXrJg6hMgvtmdpRwkxlZBbTk6qWD7wDzDLiJQZuomE3PtSsGmisEyg
Z5hBleOnJUjBGrNIxQ4p5Kk5hLqsL6v5pNyZd6wjHbEteTx+35I5sFAdWbQSKR0w/6E8q186
HpUIonKoQhMuscmZve8p7J0yUbYNh6MlBJ0cQaaeheuQKhr2EqmOEAtv5LS4VTxlSMnHpDpj
aw/dPa/WIiWfkNIGP/DojpBLanNPHUlQHQ2TXIcUu3kK5q3Ot5IE6birp5JEGUE2NaBzs0hF
PU+hcTTwctmmBLo3k0B3ZNL6Z0lFRhR2j8ZT0m6DTQMtnWf3RMx9/sPOKtAJdhKpoyGVLkxK
D3Mdqj0LFPZs3qIOLqmGSL1GiO7djE7PQQqiUl4o/wODS0qLwoLsTUqniAOL7uqJVMIzf1Eu
KbNLuJbenhq6J1IxT/1E4WjukkJawF7dm9RASaJgES9RQZ38S8rsp6YTonwGQXst7OItisWd
KCKVzyWlhVlBgfqpz2ZGe5KKzfcDCPHzVDRKiIbNiOKh/8EUgtCbmFJC6ynMHJpB1JghgeVG
1/1T3wokMXv9PyEIpyTv5EnHbZQBT4yfsvZkbBpuo8vcrVAKCMLfIu4F6d2DFiWmfIXB4htI
DJ9OmleIsQIvOoHi2A6CmJnUcNA+B4FE5qYDKNGJn1YMCEFQpb9RTD4l59qI8JQN+/XENFDb
LS+GONL5DDnNiBRWJLYyeIfI7LktQZPNEUQXVnMYHKLOmhz1uCuJQkej95yThy7LfwutmtoM
DRqgnu/vhPTJ2KECvdW/feZFri5VpsLaeskcCNrVH7+RdKM6necb36soCpXnuUJZ17eGq6rq
6suy3PaTNTWMsi+K6vF7U1EuKcbYICnE7M+IS5DCb1cwhnAzYWOeggCi5BITQqi3kXqrsDFP
ucIwdH1h/Q5sRuqRsFVn5JinhoT1h3I1Wq+Qcmekz/ureaovyuf9TUhxzrcn9crwfZyn3kLq
+z31/Z76VE/92e0U4qNIzRa1hqdGRO3V41ieFAkZCy9RS3nqBVHf76kvnH0fs/b5XJtldK/P
SFutff8dqY/wFMQMxccJepuwZ4LeIuz7RX2/qK8Q9ZEpYYnk+Rf5995jiU/tjgAAAABJRU5E
rkJggg=='! !

!LightDiodeMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color gray;
		 yourself! !

!LightDiodeMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color gray;
		 yourself! !


!PhotoresistorMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!PhotoresistorMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (25 @ 11)! !

!PhotoresistorMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color gray! !

!PhotoresistorMorph methodsFor: 'accessing'!
value
	^ [device value]
		on: Error
		do: [-1]! !


!PhotoresistorMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#ldr #(#(#slot #lightValue '' #Number #readOnly #Player #getLightValue #Player #unused))) )! !

!PhotoresistorMorph class methodsFor: 'parts bin'!
defaultNameStemForInstances
	^ 'Photoresistor'! !

!PhotoresistorMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Photoresistor'
		categories: {'Electronics'}
		documentation: ''! !

!PhotoresistorMorph class methodsFor: 'as yet unclassified'!
device
	^ Photoresistor! !

!PhotoresistorMorph class methodsFor: 'as yet unclassified'!
isAnalog
	^ true! !

!PhotoresistorMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAADwAAAAgCAYAAABO6BuSAAAABHNCSVQFBQUBSsjp7wAABMRJ
REFUeF7lmCFY40AQhSuRSCQSiUQikUgkEhlZGRkZGVkZWRlZWYlEIiuR5/beP9nJt5cmaeAK
5Y5+37Alze7O2/dmdnYXx/qcnZ0F/Q3euh3j//bZN/rg0NXVVbi/vw+Pj4/h6ekpZFkW8jw3
K8vSbLVamdV13X2vqsqsKAoz3l8ulzYG9vDwYGN/G9AXFxfGBM7heCmghZws7u5CfnMTcjlb
XF6GUu8VcrqUde1iYd/z8/OQ6/el3suvr0N+e9uOwZhaBMZmjnauE35u5ZhLD0ZLWBGITACW
AprreyUAtZ6vxdpazmON2F7LrOWZWK3Vv5I6ALtUn0zgMh9LfX2eds7TiblzxOQrVgGKVDeb
TSjFWC0QfN9IxgBsAAh4TH3smZSxaZr2PZnLnQXMztqx07lOAvVSYFInLP6Qo2TsjteS5Yr/
Ba5Bni5rseZmsk4MRQDeAAsoimHsdK527hOyixG/xOBKIAG73W7Ds2z3+mr29vYWdrtdeH5+
7n7vWtiVApA3sQ3z/FaJfWRNwuvPd7LY/QOwGCQWHQwAMQf7BmAytLJ5JeZhs1QI0FYaE0XA
chNDgmwOw4zdn+9G/b90G+rvlUgwT9gBtIN12728hK1YXEVwxDcJjdYWQcD5zfs3Yn4p2QN4
eL/+Yjkz6bkcorW9FMAC5Ay/IueE4Z3kvBZAS2CwuF7vy7vXohoWM53rS2VNYcFkFBleHPCM
eDM5knGjs5iDxjbxndRIXFOgC0meGPa5sDvtBvhAUfLXgNKKZ6gldpgwdcArq0JsAHjMeZKT
LQjMypq4AFNMAzitvFLQ+DLmp7eTYA91pmWSPlBanKK6Qq5jziNj26qkDmv1vgHWQowyrPlS
wD4fhi+H/B0FPQcs7bUSS3+1O4YFAFBjzgMUCVuGjsazqRguNN8Qww54rt+DUp7LMPGbrnQH
WPuwbylDzpOB0yzsMp+MYcpMjd2fDx/mMtxWagcYxvxUk7YkCjJlmrQw6yd5UiOPOc8W1CUs
PzzItrEy24t5mR0oqLiSudwHkmXfP6vQ5MO7Gabz1Lbk2wRlHq3vwySiKca6mpqDQ1wkktZg
zLMPa3y2PObgtOSns6ltCV/ezTCd5paVvg9T6NeKN3eajGwVFAWGJAlAM71jxQbHwIksjQ9Z
XMz90nIa8FEZJnH1J3fnqng6wmkrGb105Ezshwax5FXVWgsxBHatRbBFjKVlv9KaKi0/geF9
lokbOwMLRBMTEWDZeuZUVKYIzYkq6O83IWO19JRnsxj+6E1HCthuOGAzOo1805sN25KccWdf
zKcJLI/hYdc/6p8NHA+J50OADzJ8jAuAgu0q1r44TVg0ydHPYtcPC35w8NjmzisyyjWRXxfx
/3svAD6F4X4sW6UVbyhc2tyAFNTZcrwGMGUli0A1RmnJQsAmSmAf17tdf/Zfrne460queNo5
p6vFIRt8+ZdWE/vIUdEu8aiNtUfaVQ8VkhzHaUDYXZdsqHWzdwEYF4yxylhwzJHyGNhR0B8B
7NL2Ghs2XEbEtScflzmy5SaSxamijNPf0ytbxqLCgtVD599DYAdBfxzwftYe2qvTi/XU5vVd
LI4C2EGO2eIf+fx8wJ8v6Z8P+OcDPjXoxf/4OQT2N7wErkw3uOHnAAAAAElFTkSuQmCC'! !

!PhotoresistorMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color gray;
		 yourself! !

!PhotoresistorMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color gray;
		 yourself! !


!PotentiometerMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!PotentiometerMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (1 @ 60)! !

!PotentiometerMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color red! !

!PotentiometerMorph methodsFor: 'accessing'!
value
	^ [device value]
		on: Error
		do: [-1]! !


!PotentiometerMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#potentiometer #(#(#slot #value '' #Number #readOnly #Player #getPotentiometerValue #Player #unused))) )! !

!PotentiometerMorph class methodsFor: 'as yet unclassified'!
defaultNameStemForInstances
	^ 'Potentiometer'! !

!PotentiometerMorph class methodsFor: 'as yet unclassified'!
device
	^ Potentiometer! !

!PotentiometerMorph class methodsFor: 'as yet unclassified'!
isAnalog
	^ true! !

!PotentiometerMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Potentiometer'
		categories: {'Electronics'}
		documentation: ''! !

!PotentiometerMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAAEAAAAB/CAYAAABfRcSmAAAABHNCSVQFBQUBSsjp7wAAA51J
REFUeF7lnK3S6jAYhCuRyEokEolEIpFIJBKJRCKRvQQkl/DJI5FILuO4nmz6LSfT0p9AIW03
Mzsv/SFNNi8PbWASfbLMZrN0NBo9FEWjdDwe2+juxz5329VyuUyjPpZ85+M4tnE6ndo4mUys
YMZ8Pn8YgX3u+RCO96rz6/X60UF0GIIh6AiEbYzsYrEovMZxnEuxnl5lAgxA4zGKNAHbq9XK
dhSjjg7hPKY5TYMBNASRxiH2ygA0Gga4GYAOZSP5v9NIe7zebDb2fBpAE5g1vfoYVGVA3gDZ
DIAZkhmgzwB9BugzQJ8B+hmgzwD9DNBngD4D9BmgzwB9BugzQJ8B+gzQZ4A+A/QZoM8AfQbo
M0CfAfoM0GeAPgP0GaDPAH0G6DNAnwH6DNBngD4D9BmgzwB9BugzQJ8B+gzQZ4A+A/QZoM8A
fQboM0CfAfoM0GeAPgP0GaDPAH0G6DNAnwH6DNBngD4D9BmgzwB9BugzQJ8BHS77/T7d7XZW
XPuDC6NAbjZwMRUutIJz8ZqLqFB4jyt3f7YAS0cKR/Wbypbl6UjhcjiyBmSAGgWQsAHZilQd
KQCadAbIQzBEBnTKgOwmRdgA3t/r3wfoZ4DotwAMcNcA/IY+9nTIBQ/5FFcX+dQWIuLpsmk7
GRt9pfkIhoU0wbe9jYDm4ygnOkJ0HgqeAWxICBOg4Bmgz4ChMQCfaR9H83N4346tZ8Dlckm3
262dpESKucIF+RrHMZN7PB7t+ZzB9Yl5oPm8H23AtTEHWdVOCm09nU7lBqCikCP57Vgw4Hw+
p0mSvKTD4WAdrhNHpo3I7HtVBQPQkXcqrBNM4rR5aGEK/6kBOOArdhCfL7fD+W1+Xvn7Qcj4
1AA0+BUnB5MBNMDXybqRd7f1M6DrDHjFSX0G6DNAnwHDyAA0kPf3TSOECvEsUBf5fOFT/6ci
pJ8B+gzQzwDP+wC+2ankrfuAJ/W1EhvUV5oBGCUczMfEQOM6HqfXOLa6GSUGKDjuK2uaaQjr
oi5mkqPs+rXR6MfM+Lj1/ZjZn8NvZ5+9z/sHk7up8I+ZLruahiLe3/zbWtfrK5Tb7wWoe5P5
tb7V9zeKUqjK4ccFWhqxTtVXZYB+BgyVAex0mYaRARX/MWhqQL8Z0PBPFvoMUGRAqAwou1Ps
SkYVHTa3mjdH9zf+r8/O5nnzjglttu+jpazzbZjQi1LVedcEfQP0DdA3YLgGSEPwU1+DvTWh
rRuhV8s/Fy4WI3oKOKEAAAAASUVORK5CYII='! !

!PotentiometerMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color red;
		 yourself! !

!PotentiometerMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color red;
		 yourself! !


!PushButtonMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (12 @ 25)! !


!PushButtonMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#pushbutton #(#(#slot #isPressed '' #Boolean #readOnly #Player #getIsPressed #Player #unused))) )! !

!PushButtonMorph class methodsFor: 'as yet unclassified'!
defaultNameStemForInstances
	^ 'Pushbutton'! !

!PushButtonMorph class methodsFor: 'as yet unclassified'!
descriptionForPartsBin
	^ self
		partName: 'Pushbutton'
		categories: {'Electronics'}
		documentation: ''! !

!PushButtonMorph class methodsFor: 'as yet unclassified'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAACIAAAA8CAYAAAADm2gpAAAABHNCSVQFBQUBSsjp7wAAA1tJ
REFUeF7lma1z4zAQxQMDAwMDDQ0NDQ0NDQ0NAwMDAwMDD96fUFhYGBhYeLCwTLc/1evTOP6Q
v9rcxDM7Gjvy7tPbJ2mtrL77+lytDLb66et/ALI23TZf8DZ7NCDPr5HnB/L817jrfbcztyAw
V2nft9tFcohf/F8lDvGaO4WheRO7RpHtvAQQC0L8E4d4zUAE5VsJBmaWAHITIL0xlBHLyoKM
aIx2Rsrc0fn2Uxo5n8/mID++JIl5TVPzKu2v08nw/HK52FZt7P1F7AXfpf2OY/v8Dohrh8PB
7Pd7U38+xU4yMHyeygGq3QEBOZ1CyV0kymbn3QqVpxmYKYrC+txsNma9Xpssy6rfGxlJhTJe
4EUtA+KSwinGgPAZWoGuLRgdYCMQgtbrEV6eohECanBM/R6Px3YgLhNqeZ5PZmRnZ8g/n6So
UyO0BIZKjFy25TyRmUUaMViDTVLbpClGTx8YCWR2Mhk6NdJnqB6HWCpA9kVeWS6g4/gLFIB8
fbYCacs5TDGaWBg4SuBDnpkiic0+jat2nyYmE2aUIdjp09AgRkgFIBJmlBNcrX6fi0XlMjCY
kS7kjLAOoq9VMKqzNv/ejJBvgPgwUb9PSiHPohHojaPQmwm3zZOoWiAnawRtpHE0iAn3PuqZ
RV4a0b0nEyBjGFEgrDmTNQIjWRyN0gj3IbNNgEzWiJ0xYTiaETuQlhV6ECN2CRdnYzQCk+wz
usFNWkdY1nFWT49PG8p7uqhN1oiysqOmSPw1QjrZOPsqvUF7jc4ewORJPxNJGFgQTNtZ9xp3
K6eWiCVQ7qwtCiKVhS/YbSsQo3ZfFyn1Ql1g+jszgEAAog1EB7uyfuEZYN16o16Ue2lEU6C1
JVOvXnW7tYkWR2z5AGzrq/Wqlorukt8IBMdQ6paMdYqH1qxaPAM8sJ+ZX347gehnhGs+NUWf
tpoOCVuLZ0ZCFVZ/QWmc8l2DdryLZzc9dMSG1J5dhkhZFNEIaXJFewdEqZrrW9f3/g5IIsov
cirywhqo5zb1jWUl2/dHBiJKDlJuCx5LVP45HvM6MVrooGbQidHzn6Hp9Qcm0ImIdgkgzMom
u+v4IevHp9iHAPm0K+z8IOp/j7SCWeJqA/HtYLpAuGCeH8hzA3kIsT7M9PVd0P4CUbMRqU5J
GVIAAAAASUVORK5CYII='! !

!PushButtonMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ true! !


!PwmLightDiodeMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!PwmLightDiodeMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (7 @ 35)! !

!PwmLightDiodeMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color gray! !

!PwmLightDiodeMorph methodsFor: 'value'!
value
	^ [device value]
		on: Error
		do: [-1]! !

!PwmLightDiodeMorph methodsFor: 'value'!
value: t1 
	[device value: t1]
		on: Error
		do: []! !


!PwmLightDiodeMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#led #(#(#slot #ledValue '' #Number #readWrite #Player #getLedValue #Player #setLedValue:))) )! !

!PwmLightDiodeMorph class methodsFor: 'scripting'!
defaultNameStemForInstances
	^ 'Pwm Led'! !

!PwmLightDiodeMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Pwm Led'
		categories: {'Electronics'}
		documentation: ''! !

!PwmLightDiodeMorph class methodsFor: 'as yet unclassified'!
device
	^ PwmLightEmittingDiode! !

!PwmLightDiodeMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ true! !

!PwmLightDiodeMorph class methodsFor: 'form'!
form
	^ LightDiodeMorph form! !

!PwmLightDiodeMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color gray;
		 yourself! !

!PwmLightDiodeMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color gray;
		 yourself! !


!ServoMorph methodsFor: 'accessing'!
angle
	^ device angle! !

!ServoMorph methodsFor: 'accessing'!
angle: t1 
	[device angle: t1]
		on: Error
		do: []! !

!ServoMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!ServoMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (69 @ 76)! !

!ServoMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color yellow! !


!ServoMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#servo #(#(#slot #degrees '' #Number #readWrite #Player #getDegrees #Player #setDegrees:))) )! !

!ServoMorph class methodsFor: 'parts bin'!
defaultNameStemForInstances
	^ 'Servo'! !

!ServoMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Servo'
		categories: {'Electronics'}
		documentation: ''! !

!ServoMorph class methodsFor: 'as yet unclassified'!
device
	^ Servo! !

!ServoMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ true! !

!ServoMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: '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
RU5ErkJggg=='! !

!ServoMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color yellow;
		 lineWidth: 5;
		 yourself! !

!ServoMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color yellow;
		 lineWidth: 5;
		 borderWidth: 1;
		 yourself! !


!SwitchMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (-12 @ 23)! !


!SwitchMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#switch #(#(#slot #isOn '' #Boolean #readOnly #Player #getIsOn #Player #unused))) )! !

!SwitchMorph class methodsFor: 'as yet unclassified'!
defaultNameStemForInstances
	^ 'Switch'! !

!SwitchMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ true! !

!SwitchMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Switch'
		categories: {'Electronics'}
		documentation: ''! !

!SwitchMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAAC0AAAA3CAYAAACYV8NnAAAABHNCSVQFBQUBSsjp7wAAAcRJ
REFUeF7lmaGSgzAQhiORyEpkZWVlZWUlEomsRFZWIpFIJJJHOIlE3mOc28syR6/TI+ymHLCZ
7Mw/O8xsk69/kk2HqiUjjmM4HA6w3++NWUkLhH4GHPT8LBLaSacvlwtMZZHQu90OwjA0ZpHQ
CDaltwdeSufzmXT6nXGV6VRPPQdBoB0KyIyinI6iyGr+0+kEijrdY3kA4ohyeoDmzt9D2zj8
21t5wOg45TTC28zvttO2e/q/nbaZH7/kW04jDFcINpVfAancm2YDIEG90zb7U4LcheZeFFJy
3z2o0y1NSZKAovqotJymqf9O+++0/07777T/Tvvv9AJOm35oU5pTj9m2flCWZebXDrfbDe73
O5jy2vWsmBoQ89r1rHDS6aIojAOWZQlr11tFnuePAXGiretZUdf1w4GmaWDrelZUVfVwgjPo
0vU8aL1k+fUKhe6PNWP5lq5nRXs8QqebfavVSfy7YSw6fSN9aPXwrkC3CPwD/smE/lIKUJs7
jepcgXbaaWpPD6Am/f0E9QpsjtMatGVsD1HQzu1pvKXGJBZ6AHxdZg74JtAmYBvwTVymDpb/
0P5Duwbt3EGc2/JEgNteLkvHNxOTNSxBILeUAAAAAElFTkSuQmCC'! !


!ThermistorMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!ThermistorMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (12 @ 20)! !

!ThermistorMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color gray! !

!ThermistorMorph methodsFor: 'value'!
value
	^ [device value]
		on: Error
		do: [-1]! !


!ThermistorMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#thermistor #(#(#slot #temperatureValue '' #Number #readOnly #Player #getTemperatureValue #Player #unused))) )! !

!ThermistorMorph class methodsFor: 'parts bin'!
defaultNameStemForInstances
	^ 'Thermistor'! !

!ThermistorMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Thermistor'
		categories: {'Electronics'}
		documentation: ''! !

!ThermistorMorph class methodsFor: 'as yet unclassified'!
device
	^ Thermistor! !

!ThermistorMorph class methodsFor: 'as yet unclassified'!
isAnalog
	^ true! !

!ThermistorMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAACEAAAAxCAYAAABUMsD0AAAABHNCSVQFBQUBSsjp7wAAAa9J
REFUeF7lliGPhDAQhfuzkEgkEolEIpFIJBKJRCKRSCQSiUQiz/Xymp1L79IC7ZblkjZ5gewO
M1+mM9My07WuK+/7ntd1zcuyFMI7fsN/7M61LAsvioLHcXwoQMHWOUDbtr+CNE1zCtR1nTsQ
pFp2niQJT9NUPM+ygm+dZsBWb2UE+/ouAMm6RrD3riBQP8ymDV0BQFEUmWcDPe8SIgxD0VFG
EFVVOYfI89wM4spQMoVAWxtBgNolRBAEYq481hkEkWXZczWBzgCEcU3cAYHsXgbYtk0Ukes5
AcH3I0Up61KHDMNwGwAJg9B6PlBKSWfptz5HVFuBQYPC0gn/62xUMIddsu87R1fIIKDGYUbb
dAQjC4MJ3+BbeebAN2IglhJinmdhACE4nqqDDcWlC46BhOCq4QeRf+2JOo7jj9Eh7Str0zSJ
gBDez+xl34ilPb7JyMndUDEASapsiYW7IBkZn/0XL8zkX9umd0PAJ/nXXn7/BQSu9/5D+A/h
P4T/EP5DXIG4e/kPId+s/kpp/MUYhz4BoAVxDXEGoAR5DIIC6+QPhP818QkIqxZ9alh9A2Xu
OS0/zY37AAAAAElFTkSuQmCC'! !

!ThermistorMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color gray;
		 yourself! !

!ThermistorMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color gray;
		 yourself! !


!TiltSwitchMorph methodsFor: 'attachment point'!
attachmentPointBorderColor
	^ Color gray! !

!TiltSwitchMorph methodsFor: 'attachment point'!
attachmentPointCenter
	^ self center + (16 @ 20)! !

!TiltSwitchMorph methodsFor: 'attachment point'!
attachmentPointColor
	^ Color gray! !

!TiltSwitchMorph methodsFor: 'value'!
value
	^ [device value]
		on: Error
		do: [-1]! !


!TiltSwitchMorph class methodsFor: 'viewer categories'!
additionsToViewerCategories
	^ #(#(#'tilt switch' #(#(#slot #tiltValue '' #Number #readOnly #Player #getTiltValue #Player #unused))) )! !

!TiltSwitchMorph class methodsFor: 'parts bin'!
defaultNameStemForInstances
	^ 'Tilt Switch'! !

!TiltSwitchMorph class methodsFor: 'parts bin'!
descriptionForPartsBin
	^ self
		partName: 'Tilt Switch'
		categories: {'Electronics'}
		documentation: ''! !

!TiltSwitchMorph class methodsFor: 'as yet unclassified'!
device
	^ TiltSwitch! !

!TiltSwitchMorph class methodsFor: 'as yet unclassified'!
isDigital
	^ true! !

!TiltSwitchMorph class methodsFor: 'form'!
initializeForm
	^ form := PEUtilities formFromEncodedPNG: 'iVBORw0KGgoAAAANSUhEUgAAADoAAABDCAYAAADNlhYhAAAABHNCSVQFBQUBSsjp7wAAAtFJ
REFUeF7lmCGz6jAQhZFIJBKJRCKRSCQSiUQikUgkEolEIpFIJD/j/YPc9/XNvlkyKdy2zHSb
3ZmdcGnh5vTbTQ7p+Q//4T98x+PxCNmKu91u4XK5BMb7/V5kNuKez2e4Xq9FIlJGEZqFWBGV
Sq51XiilGRNMjYikV7m/c2VaRjCVulc7szjJQvMbkqle7QTV8/kcTqdTJZq6V6FpnioC9/t9
OB6PAcFViTJC03SvIm632xVCySZUzZYw9ESg5OFweJl8ldGsiUCUFilkoVyHqlkTwcRiokK1
aa+apKp7VMjWpWq2Vz9RzapXoad7VPIbvWqKKpMpo8p2U6dXzZoIoRqTFRNRh6pJE8GTT1HV
JqIOWSFqql/FCsZk9cJUh6q5XuXJv6PatFdNUYVcal/NjmrKGn6zV2OxshW1aiJist+gKqLi
xc8cVW0impxEiFB5mK2VNZNL7atiIr5xEiEPU77fhImIe7XurxuSz8YiGblmwho2OYlA3Ha7
Dev1Omw2m5fX+nvNmIiqvcrnESXi5vN5mE6n/3O5XL48xNaopkyETOodVa4hjoScFqcT0vrX
EyVt6mzp3akhE5ayRMxkMgnD4TAMBoPitYjkPtlqdK+2enpfdhKhqXIPAinR2WwWxuNx6Pf7
fyf+L3ktIrlH/w9dKa1axTKqYiKYOEnPQQ16iIMkArXIVHlqoq174nhLkPIVioiAIgIZeZ97
RqNRcQ3KZYuNCfOQMhFCEzGy2CAIkQjShPh7tVq9nbwporGJYLFZLBYvJEnei1fnT99rpke1
iYCkFilCISolW3UVNUeUfRUh8cavk4dQ1cOa6lFZfcsMAAKhQS93nijB4iLiKN/UdtGEqKkj
l0+TyYJoVUKd7NHfhhuiTSogW6Hik+N0IbIzYv/0eoFsIrITYv0LzUGoiCtL/0L9l24mQt1s
L64Mg//wH/7Df/gP/+E/2o0fEV6ezxg6pUkAAAAASUVORK5CYII='! !

!TiltSwitchMorph class methodsFor: 'connectors'!
newConnector
	^ ArduinoWireMorph new lineColor: Color gray;
		 yourself! !

!TiltSwitchMorph class methodsFor: 'connectors'!
newConnectorFromMorph: t1 toMorph: t2 
	^ (ArduinoWireMorph fromMorph: t1 toMorph: t2) lineColor: Color gray;
		 yourself! !

ArduinoMorph initialize!
