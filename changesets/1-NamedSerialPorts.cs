﻿'From etoys4.0 of 9 October 2008 [latest update: #2340] on 19 December 2010 at 10:52:54 pm'!
"Change Set:		SerialPortManagingNamedNodes-sk
Date:			13 January 2009
Author:			Séverin Lemaignan

Recent Linux kernels don't mount most serial
devices on /dev/ttySxx, but on more specific nodes, like /dev/ttyACMxx
for modems, /dev/ttyUSBxx for certain USB->COM converters, etc.

This change set adapt the SerialPort class to a new version of the VM SerialPlugin."!


!SerialPort methodsFor: 'open/close'!
close
	port
		ifNotNil: [port isString
				ifTrue: [self primClosePortByName: port]
				ifFalse: [self primClosePort: port]].
	port := nil! !

!SerialPort methodsFor: 'open/close'!
openPort: t1 
	self close.
	t1 isString
		ifTrue: [self
				primOpenPortByName: t1
				baudRate: baudRate
				stopBitsType: stopBitsType
				parityType: parityType
				dataBits: dataBits
				inFlowControlType: inputFlowControlType
				outFlowControlType: outputFlowControlType
				xOnByte: xOnByte
				xOffByte: xOffByte]
		ifFalse: [self
				primOpenPort: t1
				baudRate: baudRate
				stopBitsType: stopBitsType
				parityType: parityType
				dataBits: dataBits
				inFlowControlType: inputFlowControlType
				outFlowControlType: outputFlowControlType
				xOnByte: xOnByte
				xOffByte: xOffByte].
	port := t1! !

!SerialPort methodsFor: 'input/output'!
nextPutAll: t1 
	^ port isString
		ifTrue: [self
				primWritePortByName: port
				from: t1
				startingAt: 1
				count: t1 size]
		ifFalse: [self
				primWritePort: port
				from: t1
				startingAt: 1
				count: t1 size]! !

!SerialPort methodsFor: 'input/output'!
readByteArray
	| t1 t2 |
	t1 := ByteArray new: 1000.
	t2 := port isString
				ifTrue: [self
						primReadPortByName: port
						into: t1
						startingAt: 1
						count: t1 size]
				ifFalse: [self
						primReadPort: port
						into: t1
						startingAt: 1
						count: t1 size].
	^ t1 copyFrom: 1 to: t2! !

!SerialPort methodsFor: 'input/output'!
readInto: t1 startingAt: t2 
	^ port isString
		ifTrue: [self
				primReadPortByName: port
				into: t1
				startingAt: t2
				count: t1 size - t2 + 1]
		ifFalse: [self
				primReadPort: port
				into: t1
				startingAt: t2
				count: t1 size - t2 + 1]! !

!SerialPort methodsFor: 'input/output'!
readString
	| t1 t2 |
	t1 := String new: 1000.
	t2 := port isString
				ifTrue: [self
						primReadPortByName: port
						into: t1
						startingAt: 1
						count: t1 size]
				ifFalse: [self
						primReadPort: port
						into: t1
						startingAt: 1
						count: t1 size].
	^ t1 copyFrom: 1 to: t2! !

!SerialPort methodsFor: 'primitives'!
primClosePortByName: t1 
	<primitive: 'primitiveSerialPortCloseByName' module:'SerialPlugin'>
	^ nil! !

!SerialPort methodsFor: 'primitives'!
primOpenPortByName: t1 baudRate: t2 stopBitsType: t3 parityType: t4 dataBits: t5 inFlowControlType: t6 outFlowControlType: t7 xOnByte: t8 xOffByte: t9 
	<primitive: 'primitiveSerialPortOpenByName' module:'SerialPlugin'>
	^ nil! !

!SerialPort methodsFor: 'primitives'!
primReadPortByName: t1 into: t2 startingAt: t3 count: t4 
	<primitive: 'primitiveSerialPortReadByName' module:'SerialPlugin'>
	self primitiveFailed! !

!SerialPort methodsFor: 'primitives'!
primWritePortByName: t1 from: t2 startingAt: t3 count: t4 
	<primitive: 'primitiveSerialPortWriteByName' module:'SerialPlugin'>
	self primitiveFailed! !

