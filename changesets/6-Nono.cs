﻿'From etoys4.0 of 9 October 2008 [dernière mise à jour: #2336] on 21 December 2010 at 11:09:32 am'!

Object subclass: #Nono
	instanceVariableNames: ''
	classVariableNames: 'Balloon MyMorph'
	poolDictionaries: ''
	category: 'SqueakBot-Main'!
	
!Nono class methodsFor: 'as yet unclassified'!
addBalloon: t1 
	Balloon
		ifNil: [Balloon := BalloonMorph string: t1 for: MyMorph.
			(Balloon submorphs at: 1)
				fontName: #Accula
				size: 12]
		ifNotNil: [(Balloon submorphs at: 1)
				contents: t1].
	MyMorph addMorphFront: Balloon! !

!Nono class methodsFor: 'as yet unclassified'!
balloonFont
	^ StrikeFont familyName: 'Accula' pointSize: 24! !

!Nono class methodsFor: 'as yet unclassified'!
display: t1 during: t2 
	MyMorph
		ifNil: [MyMorph := ImageMorph new.
			MyMorph position: 50 @ 50.
			MyMorph newForm: Nono nonoBitmap].
	MyMorph openInWorld.
	self addBalloon: t1.
	MyMorph world
		addAlarm: #removeBalloon
		withArguments: #()
		for: self
		at: Time millisecondClockValue + (1000 * t2).
	^ MyMorph! !

!Nono class methodsFor: 'as yet unclassified'!
removeBalloon
	MyMorph world removeAlarm: #removeBalloon.
	Balloon
		ifNotNil: [MyMorph removeMorph: Balloon]! !

!Nono class methodsFor: 'as yet unclassified'!
reset
	MyMorph
		ifNotNil: [MyMorph submorphs
				ifNotEmpty: [MyMorph removeMorph: Balloon]].
	Balloon := nil.
	MyMorph := nil! !


!SqueakBotBitmapLibrary class methodsFor: 'as yet unclassified'!
nonoBitmap
	^ Form
		extent: 162 @ 201
		depth: 32
		bits: (Base64MimeConverter mimeDecodeToBytes: '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' readStream) contents! !

