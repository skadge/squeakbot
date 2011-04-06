'From etoys4.0 of 9 October 2008 [dernière mise à jour: #2342] on 20 December 2010 at 12:05:36 am'!Object subclass: #SqueakBot	instanceVariableNames: ''	classVariableNames: 'DeviceIndex RegistredDevices'	poolDictionaries: ''	category: 'SqueakBot-Main'!Object subclass: #SqueakBotBitmapLibrary	instanceVariableNames: ''	classVariableNames: ''	poolDictionaries: ''	category: 'SqueakBot-Main'!!Flaps class methodsFor: '*SqueakBot'!defaultsQuadsDefiningSqueakBotFlap	^ {{#ArduinoMorph. #openInWorld. 'Arduino' translated. 'Add an Arduino board' translated. SqueakBotBitmapLibrary arduinoIcon}} asOrderedCollection! !!Flaps class methodsFor: '*SqueakBot'!initializeSqueakBotFlap	| t1 |	self registeredFlapsQuads		ifNil: [self initializeFlapsQuads].	SharedFlapTabs		ifNil: [self addAndEnableEToyFlaps].	self registeredFlapsQuads at: 'SqueakBot' put: self defaultsQuadsDefiningSqueakBotFlap.	t1 := self				newSqueakBotFlapFromQuads: self quadsDefiningSqueakBotFlap				positioning: #right				withPreviousEntries: nil.	t1 referent setNameTo: 'SqueakBot Flap' translated.	t1 hideFlap.	SharedFlapTabs add: t1.	self enableGlobalFlapWithID: 'SqueakBot' translated.	Preferences sugarNavigator		ifTrue: [(self globalFlapTabWithID: 'Sugar Navigator Flap' translated)				ifNotNilDo: [:t2 | t1 sugarNavTab: t2]]! !!Flaps class methodsFor: '*SqueakBot'!newSqueakBotFlapFromQuads: t1 positioning: t2 withPreviousEntries: t3 	| t4 t5 t6 t7 |	t7 := Preferences sugarNavigator.	t5 := PartsBin				newPartsBinWithOrientation: #leftToRight				andColor: Color gray muchLighter				from: t1				withPreviousEntries: t3.	t4 := (t7				ifTrue: [SolidSugarSuppliesTab]				ifFalse: [FlapTab]) new referent: t5 beSticky.	t4		setName: 'SqueakBot' translated		edge: (t7				ifTrue: [#top]				ifFalse: [#bottom])		color: Color red lighter.	t4 position: 0 @ ActiveWorld sugarAllowance.	t4 setBalloonText: t4 balloonTextForFlapsMenu.	t4 applyThickness: 20.	t6 := ActiveWorld width.	t5 extent: ActiveWorld width @ (76 * (1 + (1350 // t6))).	t5 beFlap: true.	t5 autoLineLayout: true.	t7		ifTrue: [t4 useSolidTab.			t4 height: 20;								color: (Color						r: 0.804						g: 0.804						b: 0.804)]		ifFalse: [t4 color: Color red lighter].	^ t4! !!Flaps class methodsFor: '*SqueakBot'!quadsDefiningSqueakBotFlap	^ self registeredFlapsQuadsAt: 'SqueakBot'! !!SugarNavigatorBar methodsFor: '*SqueakBot' stamp: 'sk 12/23/2010 12:40'!
buttonSqueakBot
	^ self
		makeButton: 'SqueakBot' translated
		balloonText: 'The robotic panel' translated
		for: #toggleSqueakBot! !!SqueakBot class methodsFor: 'as yet unclassified' stamp: 'sk 12/23/2010 14:28'!
initialize
	Flaps initializeSqueakBotFlap.
	SugarLibrary default iconAt: 'toggleSqueakBot' put: SqueakBotBitmapLibrary squeakBotIcon.
	SugarNavigatorBar refreshButRetainOldContents.
	! !

!SugarNavigatorBar methodsFor: 'initialization' stamp: 'sk 12/23/2010 14:27'!
makeTheButtons
	^ {self buttonHelp. self makeProjectNameLabel}
		, (Preferences showAdvancedNavigatorButtons
				ifTrue: [{self buttonNewProject}]
				ifFalse: [#()]) , {self buttonPrev. self buttonNext. self buttonPaint. self buttonSqueakBot. self buttonSupplies. self buttonLanguage}
		, (SugarLauncher isRunningInSugar
				ifTrue: [{self buttonShare. #spacer. self buttonChoose. self buttonKeep. stopButton := SugarLauncher current willSaveOnQuit
								ifTrue: [self buttonStop]
								ifFalse: [self buttonQuit]}]
				ifFalse: [{self buttonZoom. #spacer. self buttonFind. self buttonPublish. self buttonQuit}])
		, (Preferences navControlInNavBar
				ifTrue: [{self buttonHideNavBar}]
				ifFalse: [#()])!
]style[(14 5 4 13 4 28 11 44 4 34 3 6 4 13 4 13 4 36 4 17 4 22 13 32 4 14 7 2 4 15 4 13 10 4 13 41 4 31 4 30 4 13 7 2 4 13 4 16 4 20 11 34 4 34 3 2)f3b,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3c202202126,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3c202202126,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3c202202126,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3cmagenta;,f3,f3c202202126,f3! !!SqueakBotBitmapLibrary class methodsFor: 'as yet unclassified'!arduinoIcon	^ Form		extent: 60 @ 42		depth: 32		bits: (Base64MimeConverter mimeDecodeToBytes: '6dgVAAsKCGmH8whqiCr/CGuJD/8Uco7/MoOb/w1tiwr/B2uJF/8KaYX/El10/xJedv8SXXT/
El50Gv8TX3YK/xRfdgv/E192/xNfdQr/E192I/8KaYX/B2uJ/xNgeP8TXnX/FGB3/xNedf8T
YHf/E191Cv8TX3Yr/xNgd/8TXnX/FGB3/xNedf8TX3b/El10/xJedv8SXXSuEV93BQN0lBkA
CwoIaYfzCGqIJv8Ia4mv/wRph/+mxc//7e7u/2KesP8Dbov/BHKQ/xJke/8lIyT/Ky4x/yUl
J/8uLi7/ISQn/ygoKv8jJCb/ISIk/yoqK/8gIyb/MjIy/yYmKP8rLjD/IyMl/ystL/8YGh3/
EmR8/wZsi/80PkH/FxYa/zg8Pf8UFBf/Oj0+/wgIDf8/QUH/BgYL/zo9Pf8SERX/Oj4//xQU
F/86Pj//DAsQ/zw/QP4GBQv/JEtXbQdsihkACwoIaYfzCGqIJv8Ia4mv/wZpiP+BsL///ff1
/1eYq/8DbYz/BnCN/w5lf/8mRU7/KUpU/yVFT/8nSFL/KktV/y1NVv8rS1T/LExW/ytKVP8s
TVf/LEtU/y1NVv8pSlT/LUxW/ypLVf8sTVf/DmV//wZriv8nTVj/LExV/ypMVf8uTVb/K0xW
/ypKVf8sTVb/K0tV/ytMVf8rS1X/KkxV/yxLVf8qS1X/KEhR/ylKVP8mR1H/HFdocgdrihkA
CwoIaYfzCGqIKv8Ia4kP/wVph/8AZoX/BmqICv8IaoiX/wNoh/9Olqr/DnCN/1aarv9Djqb/
GnaS/yF7lv8bd5P/J3+Y/xJyj/8cd5P/DW+N/yd+mP8Uc5D/LoKb/xFyjv8sgZr/BmqI/whq
iP8Faoj/NIaf/whsiv8ScY7/Cm2L/zeHn/8BaIf/LYKb/wJoh/8zhZ7/B2uK/zCDnf8Gaon/
KoCa/wJoh/9NlKn/CmyKcghqiBkACwoIaYfzCGqIPv8Ia4mX/wRoh/9Kkqf/MIKc/z+Lo/8p
fpn/GHWQ/yp+mP8mfZf/InqU/w1ti/8vgZr/DW+L/yl+mf8Ja4n/LYCa/xdzkP84h5//BGiH
/wNohv8BZoX/GHWQ/wlrif84iJ//CWuJ/0GNo/8BZoX/O4qh/wNohv80hp7/CGuJ/zeGn/8G
aoj/Qoyj/wBmhf9Jkaf/DG2KcghriRkAEwoIaYfzCGqI/whqiP8HbIoK/wdriRL/CGuJC/8H
a4n/B22LCv8GbYsH/wdriQr/Bm2Ll/8DaYj/RY+m/xl2kf8pfpj/L4Kb/yh+mP8MbYv/IHmV
/yJ6lf8Pb4z/KH6Y/wxti/8eeJP/B2qI/wJnhv9Fj6X/S5Ko/yl+mP9Lkqj/VJir/yyAmf8x
g5v/A2iH/wdqiP8EaIf/CGuJ/wZqiP8Ia4n/BGmH/whrif8FaYf/CWyJ/z6Lov8Vc4//P4ui
/xJxjnIIa4kZABsEAHfB8gZrif8EcI7/AXeX/wNykf8HaokK/wZriYv/CGqI/whrif8Ha4n/
AneW/wF4l/8Dd5b/BW+N/wF4mP8BeJf/AW+P/0iRpv8wgpv/CWuJ/wtsif8adJD/FHKP/xZz
j/8ddpL/CmyJ/xx3kv8Ia4n/F3OQ/wVph/8EaIf/I3uV/y2Amv8adZH/LICa/xJxjv8TcY3/
NYWd/wRph/8Gaoj/BGmHCv8Ia4kv/wdqiP8DaIb/B2qI/whrif8MbYv/TJOp/xt2kv9morX/
EXCMcghriQAAAAAWwmBfXyvEXl9f/EBjbv88ZnL/Omh0/ztoc/8+Y27/PmNv/z9jbv8Fa4n/
CGuJCv8IaogH/wdqiQr/CGqICv8HaohP/whriP8EaIf/CmyJ/wZujP8Cd5b/AXeW/wRvjf8H
aoj/BGiH/12dsf8mfJf/P4uj/zGDnP8qf5n/Oomg/wNoh/8FaYf/B2qI/wVphwr/B2qIJ/8L
bYr/WZuv/xp1kf9UmKz/BWmH/wdqiP8MbYr/aqW3/wpsigr/CGuJG/8Haoj/CGyK/yF8lv8M
bYtyCGuJAAAAACr/YF9fCv9fX18P/2FeXv8Ea4r/CGuJJv8Iaog7/wdqif8Ja4n/DG2I/w1t
iP8Ja4j/CGuJ/wZqiP81hZ3/XJ2w/yd+lv9hoLP/HHeS/3yvv/8AZoUW/whriUf/C2yK/5C8
yP8JbIn/k73I/wtti/8Haoj/BmmI/3esvf8Oboz/CGuJ/whqiP8HbIr/B26L/wdtiv8HbIpy
CGuJAAAAACr/YF9fCv9fX18T/2FeXv8Ea4r/B2qI/wdsix7/BHCOP/8Gb43/B2qI/ydxif+v
l1X/vZ1J/zp2if8qf5n/BGiH/0SOpP8nfZf/OYig/yZ8lv8pfpj/LICZ/wZpiBb/CGuJR/8M
bYv/UJWr/xNxjv9OlKn/BGmH/wdqiP8Tco7/VZes/wlrif8Ia4n/CGqI/wdsiv8Gboz/B22L
/wdsim8Ia4kAAAAAKv9gX18K/19fXxP/YV5e/wRriv8Iaoj/BXCNHv8BeJc//wR2lP8Iaoj/
BWuK/wBtkf8AbZL/BGyK/wVph/8Ia4n/A2iH/wVph/8DaIf/BGmH/wVph/8EaIf/B2qICv8I
a4kK/wdqiBf/CGuJ/wdqiP8CZ4b/B2qI/wJnhgr/CGuJD/8Haoj/AmeG/wdqiAr/CGuJG/8I
aoj/B2yL/wZtiv8Iaoi1CGuJAAAAACr/YF9fCv9fX18X/2FeXv8Ea4r/CGqI/wVvjf8BeJcW
/wJ4lxP/AXiX/wR2lP8Iaoj/Bm2LCv8Ac5QP/wVujP8FaYf/BmqICv8Haog3/xNyjv8jepX/
AGaF/wdqiP8geZT/BGiH/wNohv8YdJD/DG2K/wJnhv8DaIf/AmeG/wZqiCL/CGuJB/8Ha4kK
/whqiA/+B2uJ/whriaQIa4kq/2BfXwr/X19fF/9hXl7/BGuK/whqiP8Fb43/AXiXFv8CeJdr
/wF4l/8EdpT/B2qI/yFwif+Kjlz/lZJU/zJziP8tgZv/RI+l/whrif8BZ4b/cKi6/yt/mf+H
tcP/B2uI/6bI0v8feJP/fa+//yh+mP8Uco7/XZ2w/2Ohs/9zqrv/LoGa/wdqiP8Ia4kK/wds
ihP/B2qI/wprif8QbYn/D2yJCv8KbIoT/wdqiP8KbIr+AGWE/wdqiCr/YF9fCv9fX18X/2Fe
Xv8Ea4r/CGqI/wVvjf8Cd5cW/wJ3lmv/AXiX/wR2lP8Iaoj/D2yJ/z15fv9Benv/EGyJ/w9v
jf8feZT/CGuJ/wdqiP8Rb43/DW6L/w9ujP8Haoj/HXeS/whrif8YdI//E3GO/xd0kP8LbYr/
EXGN/yR8lv8EaYf/CGuJ/wRwjwr/AXiXK/8DcpH/eoGG/+OvGf+OiHf/TY2h/1qbr/9UmKz/
aKK1/7fP1/8UcY4q/2BfXwr/X19fE/9hXl7/BGuK/whqiP8HbIoe/wZujCP/B22L/wdqiP8q
cYn/sZlO/8GfQ/9CeIn/SJKo/1earQr/CGuJDv8HaogL/whrif8Gaoga/wdqiAf/BmqICv8I
a4kH/wdriQr/Bm2LK/8Ha4n/Fm2I/yZzff8db4f/EXCM/wxtiv8ZdZH/LYCZ/63J0v8ZdZAq
/2BfXwr/X19fC/9hXl7/BGuKKv8Ia4kj/whqiP8Ga4n/CGyP/whskP8Daon/BGmH/wNnh/8I
aole/whriRf/B2qI/wpsiv8Ja4n/AGaF/wdqiBr/YF5eB/9kXlwO/2RdXAr/ZF5cC/9mXVv/
BGuKCv8Ia4kH/whqiQ7/CGuJDv8Iaokf/whrif8Iaoj/Bm6M/wF2lv8Bd5f/Bm+N/whqiAr/
B2uIXv8Ia4kX/xJxjv87jaX/In2Z/wZtjP8Ha4oWGV9gYBsiSWJq9Atqh/8HcY7/A3iW/wZz
kf8KaYcK/wpqhx//B2qJ/whrif8Iaoj/BW+N/wdsiv8GbYv/B2yKCv8GbYsj/wdti/8Gb4z/
CGqI/wZsi/8FcY//BXGQ/wZti/8IaogK/whriQv/CGqI/wdsigr/Bm6MC/8Ha4n/B2yKCv8G
bowP/wdriv8Iaoj/B2yKCv8GbowH/wdriQr/B2qIEv8Gaokj/wdqiP8Iaon/CGuJ/w5hev9F
VFH/Lz1C/0NQS/8fWGcVABMKCGmH8whqiP8Iaoj/CGyKCv8IaogH/wdriQ7/CGuJP/8Iaoj/
AneW/wVvjv8Cc5L/BW+O/wRxkP8Dc5H/BXCP/wR2lP8Iaoj/B22L/wNykf8Cc5L/B22L/whq
iAr/CGuJC/8Iaoj/A3ORCv8BeJc3/wZsiv8FcI//AXeW/wF4l/8GcY//CGqI/wVyj/8Bd5b/
AXiX/wZwjv8Iaoj/DG2K/ylxhw7/KHKHI/8Zb4n/B2uI/whqiP8TXXP/UE5G/zg4OP9LST7/
KE5XFQAfCghph/MHaoj/MYWe/w1RZv8lMjH/I0RO/xFwjQr/BWmHM/8Gaoj/CGqI/wN0lP8G
b4z/BHGQ/wZvjf8GcI//BXGP/wZvjv8EdJH/CGqI/wZujAr/A3aUC/8Fb47/CGqICv8Ia4kT
/wdqif8Ia4j/BXCO/wVxjwr/BXGOCv8FcY8H/wdriQr/CGqIR/8Ia4n/CGyJ/whqiP8HbYz/
HHuT/2BYV/9+eHf/dnFw/396ef84anb/BHKQ/whqiP8QYHn/TU5J/zY5Of9ISEX/IlVkFQAv
Cghph/MGaYj/QI6l/wxLXv84MyL/JTdA/ziIoP8sgZr/KX6X/yR8lv8Haogi/whqiAr/B2uJ
Cv8Fbo0L/wdriv8IaogK/whriQv/CGuI/wN3lBr/AXiXU/8CdpX/B2uJ/wVxkP8CeJf/AXiX
/wZwj/8Iaoj/IG+H/4aCgv84ODj/NDQ0/3Rzc/9Reof/B2qI/wdrif8SXXT/XVpO/zg5Of9V
U0n/KFFbFQAzCghph/MFaYf/UZmu/wZHXP8NCQb/JThB/zqIoP83h5//LICZ/yN7lv8Haoj/
CGuJGv8IaogK/whriRL/CGqIB/8Ha4kK/whriQ//B2uJ/wF4l/8Cd5YW/wJ4lwf/AneWEv8H
a4k//whrif8Haoj/IG+H/4SAf/83Nzf/NDQ0/29ubv9Qeof/B2qI/wdrif8RYHj/P0A//zc4
OP89Pjz/IVNhFQAfCghph/MHaoj/C26M/xJPX/9BPS7/KTk//xVzjwr/BGiHE/8Haoj/B2qJ
/whrif8GbowS/wN2lCP/Bm6N/whrif8Iaoj/B2yK/wZvjf8GcI3/B2yL/whqiAr/CGuJC/8I
aoj/BHKRGv8Cd5ZT/wRykf8Ha4n/BXCO/wF1lf8BdpX/BW6N/wZti/8deJD/bmdm/3Fubf9q
ZmX/gHx8/0BwfP8EcI//CGqI/xJcc/9nYE//OjY1/11XSf8qUFoVADcKCGmH8wRoh/9iobP/
DGJ8/zM8Pv8xZnT/X56x/z6Lov83h57/K4Ca/wdqiP8Ia4n/Bm+NEv8BeJcj/wZvjf8Ia4n/
CGqI/wZujP8Cdpb/AXaW/wZvjf8IaogK/whriQf/B2qIIv8Ha4kj/whqiP8HbIn/B22M/wdu
jP8Haon/CGuJ/xFxjv82aXcK/0R3hyf/QXSE/yBtg/8GbYr/CGqI/wlrif8QZ4L/D2aB/xFn
gv8La4gVACsKCGmH8wVph/9Olqv/FFlu/1RJO/89VV//K4CZ/xh0kf8Wc4//CmyKCv8Ia4kH
/wZujBL/AnWUB/8GbowK/whriRL/CGqIB/8Ha4ky/whriQ7/CGqIB/8Ia4gK/wdqiAf/BWuJ
Cv8Eaokn/wVqif8Gaon/CGqI/wdrif8YdZD/MIKc/z2Lof9ioLP/NIWdFQAfCghph/MFaYf/
SZKn/wVqiP8QYXr/BmqI/wZriQr/B2uJJ/8HaIf/CGiI/whpiP8adZD/CGuI/wdriP8Haon/
B2mI/whpiAr/CGiIF/8IaYj/CGqI/whqif8Ia4j/CGqICv8IaYgK/whoiAf/CGmICv8IaogK
/whriAr/CGmID/8IaIj/HHWR/xh0jwr/CGqICv8Ia4gK/whpiA7/CGiICv8IaogK/wdriA//
B2mH/wRohv8HaogVABcKCGmH8whrif8FbIr/BHOS/wJ3lhL/AneVJ/8Gaon/CGiI/yZ9lv+Y
v8v/O4qi/whtif8Ia4n/CGqI/whpiAr/CGiIE/8Iaoj/CGuJ/whsif8IbYkK/whriUv/QIqi
/02Sp/8IaIj/CGmI/whqif8IbIn/CG2J/whsif8Ia4n/CGmI/whoiP9ppLb/baa4/xNwjv8I
bIn/CG2J/whsif8Ia4kK/whpiCf/CGiI/whpiP8Iaon/CGyJ/whtif8IbIn/CGuJ/wdoh/8I
a4kVABcKCGmH8whqiP8EcZD/AXiX/wJ3lg7/AniXv/8Cd5b/BmmJ/whpiP9RmKz/1+Xo/26m
uP8IbYn/CGyJ/wtsiv8ofZf/F3CO/ziGn/8bdpH/CGuJ/whsif8IbYn/KoCY/zWFnv9lobP/
eay6/wlpiP8Qboz/HniT/whsif8IbYn/J36X/whqif8IaYj/FHCO/0uQqP8sgJv/CGuJ/whs
if8IbYn/GXaR/xZzj/8sf5n/NYKd/wlpiP8IaYj/CGuJ/xFwjf84h5//Noee/xFxjv8HaYf/
CGuJFQAPCghph/MIaoj/BHGQGv8CeJe7/wVriv8KaYn/f7DB/6fJ0v+Tvcj/DXCM/whrif82
hJ3/rsvV/6DBz/+jxdL/lL3J/yB4k/8JbYr/bai4/5zCzv+dws3/vdXc/3muvP8JaYj/T5Kp
/26muP8Ibon/JX6X/425x/8bdpH/CWmI/zuHoP+dwc7/hrXE/xNwjv8IbIn/CG2J/26muf+3
0tn/mMDM/6XH0f9tpbb/C2yK/xx5k/+Qu8j/nMLO/5rCzf+Ru8j/HXWR/whriRUADwoIaYfz
CGqI/wRxkBb/AniXv/8Cd5b/BmmI/yF3lP+kxdL/a6a4/6jJ1P8xhp7/CGyJ/zuHoP+00Nf/
UZSo/wtsif9FkKX/F3SP/wtuiv+Xv8v/S5Ko/wtsif9/sL//eay6/wlpiP9Ul6z/f7HA/wpt
iv8lfZf/ocPQ/xt2kf8IaYj/CGiI/0KMov+NuMX/E3KO/whsif8IbYn/e7C+/4K0wf8Pb4z/
S5On/5C7xf8PbYv/Noef/5nBzP8TdZD/FnWQ/5rAzP80hZ3/CGuJFQATCghph/MIaoj/BXCP
/wJ3lhL/AXiXv/8CeJf/BWuK/0uRqP/F2uH/osbR/8bc4f9qpLX/CmyK/zuHoP+UvMn/Em+N
/whoiP8Iaoj/CGuJ/wtuiv+Vwcv/TpWq/w5ui/+Ds8P/eay8/wlpiP9Mk6j/h7XD/w9yjf9a
nK3/rMrT/xt2kf8IaYj/CGiI/0KMov+NuMX/E3CO/whsif8IbYn/eq2+/1+fsv8IaYj/Ro2k
/5O6x/8Pboz/NIae/5vBzf8Xc5D/GXWS/5zCzf8xhJ3/CGuJFQATCghph/MIaoj/CGqI/wdu
jBb/BXCPu/8GaIj/ZZ+y/12br/8IbIn/Tper/36xwP8QcY3/NYKd/32uvv8Sbo3/CGmI/whq
iP8Ia4n/CGyJ/2mmt/+dxM//ncPN/7XR1/9mobL/CWmI/zOFnP+hxM7/psjR/6XH0v+ewc3/
G3WR/wlrif8/i6L/nsTP/8PY3/9koLT/FXKQ/whtif9mpLb/VZqt/whpiP87iKD/e669/xBt
jP8YdZD/jLnG/5/D0f+ew9D/jbrF/xhzkP8Ia4kNABcCAAAHRgAACFYABhD2B1x2/wdkgBr/
B2N/J/8HZ4X/HXWR/w5ui/8Ia4n/Cm6K/yF6l/8Ia4n/CmuK/yF4lAr/CGiIj/8Iaoj/CGuJ
/whsif8IbYn/JHuW/y2Amv8TcY3/E2+N/whoiP8IaYj/HneT/zCDmv8Mb4v/IXqU/whrif8I
aYj/EG6M/zGBnP8yg5z/JXyW/whsif8IbYn/FnSQ/xFyjf8IaYj/CmqJ/x12kv8IaYj/CGqJ
/w5wjP8wg53/MIOc/w5wjP8HaIf/CGuJDQATBwAACOIAAAf/AAAH/wABChr/AAILF/8AAgr/
AAkS/whxkP8Iaoj/BHGQEv8BdpYH/wZwjhb/CGuJCv8IaokP/whrif8Gaoj/B2qIDv8IaolD
/wVpiP84iJ//KoCY/yd9l/8LbYv/SpSo/y6Bmv9UmK3/K4Ca/yl+l/9Qlar/N4eg/wpsiv8y
g53/I3yV/wpsihb/CGqJB/8Ha4gK/whriQ0ACwcAAAfiAAAIIv8AAAgP/wAAB/8ABw//BXiY
Fv8IaogL/whqh/8IaogO/whriQf/B2qICv8IaogX/wdqif8GaYj/PIqi/xNyjv8HaogK/whr
iUP/BWmI/yp/mP8tgZr/H3iT/xd0kP8ofpj/CWyJ/yh+mP8lfJb/FXOP/xRzj/8heZX/EG+N
/x13kv8Vco//CWuJFv8Ia4kP/wRph/8AYYL/A2iGDQALBwAAB+IAAAgi/wAACC//AAAH/wAH
EP8Bf6D/BXCO/whqiP8Haoj/B2uJ/wVwjf8EcY//B2yK/whqiAr/B2uJR/8HbIr/BHGO/wVu
jP8Ha4n/BmmI/z6Kov81hZ7/CWuJ/wpsiv8Haoj/DG2L/wttiv8JbIn/DG2K/wttiv8Ja4n/
B2qIDv8Ia4k7/wdqiP8Nbov/C2yK/wpsiv8JbIn/DG2K/wpsiv8Ia4n/DG2L/w1ui/8Ia4n/
Q42j//749v9bm64NAAsHAAAH4gAACCL/AAAIH/8AAAf/AAcQ/wF/oP8Gb43/CGqI/wdrif8C
dpUK/wF4lxf/AniW/wZujf8Iaoj/BnCO/wJ4lwr/AXiXO/8DdpX/BWqI/0aPpv80hZ7/MYSc
/zGDnf8CZ4b/V5qt/02Uq/9GkKb/Xp2x/zGEnP8XdJD/B2qICv8Ia4k//wdqiP8JbIn/baa4
/26mt/9Rlqv/NYae/0uSqP9Ikaf/BmqI/0CMov9kobT/DG2L/3Gnt//79vX/irbCDQALBwAA
B+IAAAgi/wAACB//AAAH/wAHEP8FeZn/CGuI/whqiP8EcpH/AXiXCv8CeJcT/wF3lv8Cd5b/
CGqI/wF4lgr/AniXg/8Cd5b/AXiX/wNwj/8ofpj/IHqU/x94lP8eeJP/FnOP/xVzj/8Pb4z/
GHSQ/x94k/8ZdpH/G3aS/xFwjf8QcIz/B2qI/wpsiv8bdpH/AmeG/xVzj/8EaIf/InqU/wdq
iP8YdZD/CGuJ/xp1kv8DaIf/GXWQ/wJnhv9Ij6X/CmyKDQALBwAAB+IAAAgi/wAACA//AAAH
/wAGD/8IcZAK/whqiAv/BHWS/wF4lwr/AniXk/8Bd5b/AneW/wdsiv8BeJf/AneW/wJ4l/8C
d5f/AXiX/wBxkP9am7D/Noee/0qRp/9HkKb/PIqi/3Squ/8feZT/P4uj/1eZrv9cnK//JHyW
/2ejtf8QcIz/B2qI/xZzkP9Gj6X/AGWE/1mbr/8BZ4X/TpWp/whrif89i6L/BWmI/16dsP8A
ZYT/T5ar/xJxjQr/B2qIBwEHaogJABMIAAAH8AAAB/8AAAb/AQ4YCv8BFyQP/wEXI/8BFiL/
ABklCv8AGSa7/wAdKv8IcI//CGuJ/whqiP8Fb43/AniY/wJ2lf8DdJP/BXKQ/wVvjv8Iaoj/
A3aU/wJ3lv8DdZT/BHOS/wVxkP8Ha4n/JF9w/yZfcP8ZV2r/F1Zp/yZfcP8XVmn/HVls/yFc
bf8XVmn/I11u/xZWaf8bV2n/DGWA/wdriv8TYXn/K2N0/xhYa/8xZnb/GFhs/ytjc/8aWm3/
J2Bx/xpZbP8bWWv/GVlr/y1kdP8SXnb/B2uJyghriRUAPwD////yCG6M/wVykf8DeJj/B2+N
/whsi/8Dd5f/AXqa/wJ6mv8HcI//B2qI/whrif8Ha4n/B2uI/wdriQ7/CGqID/8Ia4n/B2uJ
/wdqiA7/CGqIg/8Haoj/C2iF/yksLf8jJCX/MTAw/ycmJ/8uLS3/JiQl/ywrK/8eHR7/MC8u
/xkYGv82NTX/Hxka/xZecv8FbIv/Ik1a/xEPEv8+QED/Dw4R/zo9Pv8ZFxn/Oj0//xsZG/88
QED/FBIV/z9BQf8PDhH/KExX7AdriQAAAAABB2qIEQAnCghph/MIaoj/B2yK/wdti/8Ha4n/
CGqI/wdrif8GcI7/Bm6NEv8Ia4kL/whqif8IaogW/whriQr/CGqIDv8Ia4l7/wlphv8lS1j/
JUtW/yZKVv8nSlb/JUpV/ydLVv8mSVX/JkpV/ydLVv8lSVT/JktW/ydIU/8RYnv/B2yK/xta
bv8nSlb/KVBb/yZKVv8nT1v/KEtX/yhPW/8oS1f/KVBb/ydKVv8qUFv/JkpW/x1ZbHMHbIoA
AAAA' readStream) contents! !!SqueakBotBitmapLibrary class methodsFor: 'as yet unclassified'!squeakBotIcon	^ Form		extent: 50 @ 50		depth: 32		bits: (Base64MimeConverter mimeDecodeToBytes: '6cTjdv8AAAgH/wAABgr/AAAED/8AAAP/AAAC/wAAAwr/AAAEB/8AAAaK/wAACAv/AAAH/wAA
Bgr/AAAIP/8AAAb/AAAD/wAAAv8HBw7/Fxce/x0dJP8kJCr/KSkv/yQkKv8dHST/Fxce/wcH
Dv8AAAL/AAAD/wAABgr/AAAIC/8AAAb/AAAHZv8AAAhv/wAABf8AAAL/AQEI/wYGDf8AAAT/
AAAC/wkJEP8lJSv/ODg9/1ZWWf9xcXP/fHx+/4eHif+QkJH/h4eJ/3x8fv9xcXP/VlZZ/zg4
Pf8lJSv/CQkR/wAAAv8AAAT/BgYN/wEBCP8AAAL/AAAFVv8AAAgK/wAAB2//FRUc/zU1Ov9I
SE3/UVFV/z8/Q/82Njz/WFhb/4yMjf+tra3/tbW1/7Kysv+xsbH/sLCv/66urv+wsK//sbGx
/7Kysv+1tbX/ra2t/4yMjf9YWFz/NjY8/z8/Q/9RUVX/SEhN/zU1Ov8VFRwK/wAAB0r/AAAI
N/8AAAf/AwML/ykpL/9ycnT/ra2t/7e3t/+1tbX/tra1/7CwsP+1tbX/r6+v/6urq/+pqakK
/6ioqA//qqqq/62trf+qqqoK/6ioqDf/qamp/6urq/+vr6//tbW0/7CwsP+2trX/tbW1/7e3
t/+tra3/cnJ0/ykpL/8DAwv/AAAHRv8AAAgX/wAAB/8lJSz/jo6Q/7a2tv+srKwK/6mpqQv/
qqqq/6ysrAr/q6urL/+vr6//t7e3/76+vv/CwsL/yMjI/87Ozv/IyMj/wsLC/76+vv+3t7f/
r6+vCv+rq6sL/6ysrP+qqqoK/6mpqRf/rKys/7a2tv+OjpD/JSUs/wAAB0L/AAAIP/8AAAX/
EBAX/2hoa/+3t7f/qqqq/6ysrP+0tLT/uLi4/7CwsP+qqqr/q6ur/6ysrP/CwsL/5+fn//n5
+RX/P//5+fn/5+fn/8LCwv+srKz/q6ur/6qqqv+wsLD/uLi4/7S0tP+srKz/qqqq/7e3t/9o
aGv/EBAX/wAABT7/AAAIN/8AAAP/KSkv/6Skpf+traz/q6ur/7q6uv/i4uL/7Ozs/9HR0f+t
ra3/q6ur/62trf/IyMgl/zf/yMjI/62trf+rq6v/ra2t/9HR0f/s7Oz/4uLi/7q6uv+rq6v/
ra2s/6Skpf8pKS//AAADPv8AAAgb/wAABf83Nz3/t7e2/6qqqv+xsbH/29vbCf8X//v7+//A
wMD/qqqq/6urq/+1tbUl/xf/tbW1/6urq/+qqqr/wMDA//v7+wn/G//b29v/sbGx/6qqqv+3
t7b/Nzc9/wAABTr/AAAIH/8AAAf/AAAI/z4+Q/+2trb/qqqq/7S0tP/j4+MJ/xf/+vr6/8nJ
yf+pqan/q6ur/7GxsSX/F/+xsbH/q6ur/6mpqf/Jycn/+vr6Cf8f/+Pj4/+0tLT/qqqq/7a2
tv8+PkP/AAAI/wAABzr/AAAIN/8AAAL/Ly81/7S0tP+rq6v/rq6u/8rKyv/6+vr/+/v7/+3t
7f+zs7P/qqqq/6urq/+9vb0l/zf/vb29/6urq/+qqqr/s7Oz/+3t7f/7+/v/+vr6/8rKyv+u
rq7/q6ur/7S0tP8vLzX/AAACPv8AAAg3/wAABv83Nzz/srKx/6urq/+qqqr/ra2t/8XFxf/S
0tL/uLi4/6mpqf+rq6v/ra2t/9XV1SX/N//V1dX/ra2t/6urq/+pqan/uLi4/9LS0v/FxcX/
ra2t/6qqqv+rq6v/srKx/zc3PP8AAAY6/wAACBP/AAAF/xISGv9ra27/srKyDv+rq6sP/6mp
qf+oqKj/qqqqCv+rq6sL/7q6uv/5+fkl/wv/+fn5/7q6ugr/q6urD/+qqqr/qKio/6mpqQ7/
q6urE/+ysrL/a2tu/xISGv8AAAU2/wAACB//AAAD/yoqMP+dnZ7/ra2t/6ysrP+tra3/rKys
Cv+qqqoT/6urq/+tra3/uLi4/+rq6i3/E//q6ur/uLi4/62trf+rq6sK/6qqqh//rKys/62t
rf+srKz/ra2t/52dnv8qKjD/AAADMv8AAAg3/wAABv8DAwv/TExQ/7e3t/+qqqr/srKy/8nJ
yf/CwsL/s7Oz/7Kysv+3t7f/zc3N//b29jX/N//29vb/zc3N/7e3t/+ysrL/s7Oz/8LCwv/J
ycn/srKy/6qqqv+3t7f/TExQ/wMDC/8AAAYq/wAACAr/AgIKM/8YGB//bW1w/7Kysv+pqan/
ubm5//Pz8//+/v7/+fn5//Pz8//8/Pz//f39//v7+zb/+vr6O//7+/v//f39//z8/P/z8/P/
+fn5//7+/v/z8/P/ubm5/6mpqf+ysrL/bW1w/xgYH/8CAgr/AwMLHv8AAAgr/wAAB/8KChL/
MzM4/1RUWP9kZGf/l5eY/66urf+qqqr/sLCw/8HBwQr/wMDAB//BwcFO/8DAwAf/wcHBCv/A
wMAr/8HBwf+wsLD/qqqq/66urf+Xl5j/ZGRn/1RUWP87O0D/Dw8W/wAABhL/AAAIE/8AAAb/
CQkR/19fYv+3t7cK/66urgf/rKysDv+rq6tu/6qqqg7/q6urB/+srKwK/66urhP/ubm4/1hY
XP8EBAz/AAAGDv8AAAgT/wAAA/8hISf/f3+B/7GxsZ7/q6urE/+xsbH/f3+B/yAgJ/8AAAMO
/wAACBv/AAAD/yMjKv+Dg4X/sbGw/6urq/+srKyO/62trRv/rKys/6urq/+xsbD/g4OF/yMj
Kv8AAAMO/wAACB//AAAE/x0dI/96enz/srKx/6ioqP/ExMT//v7+hv/7+/sf//7+/v/ExMT/
qKio/7Kysf96enz/HR0j/wAABA7/AAAIH/8AAAX/FRUc/29vcf+zs7L/qKio/8LCwv/8/PyF
/x///Pz8/8LCwv+oqKj/s7Oy/29vcf8VFRz/AAAFDv8AAAgf/wAABf8NDRX/ZGRo/7S0s/+o
qKj/v7+///X19YX/H//19fX/v7+//6ioqP+0tLP/ZGRo/w0NFf8AAAUO/wAACB//AAAG/wYG
Df9ZWV3/tbW1/6mpqf+6urr/6urqhf8f/+rq6v+6urr/qamp/7W1tf9ZWV3/BgYN/wAABhL/
AAAIG/8AAAL/Q0NI/7Gxsf+rq6v/sLCw/9fX1wn/E//8/Pz/6Ojo/9zc3P/7+/tV/xP/9/f3
/+Dg4P/r6+v//Pz8Cf8b/9fX1/+wsLD/q6ur/7Gxsf9DQ0j/AAACFv8AAAgb/wAAAv8rKzH/
kJCS/6+vr/+pqan/xsbGCf8X/+jo6P+rq6v/rKys/76+vv/7+/tN/xf/+fn5/76+vv+srKz/
rq6u/+bm5gn/G//Gxsb/qamp/6+vr/+QkJL/Kysx/wAAAhb/AAAIN/8AAAX/FBQb/2xsb/+z
s7P/qamp/7u7u//v7+///v7+/9vb2/+mpqb/qqqq/6+vr//S0tJN/zf/xsbG/62trf+qqqr/
paWl/+Li4v//////7+/v/7u7u/+pqan/s7Oz/2xsb/8UFBv/AAAFFv8AAAgr/wAAB/8AAAb/
SEhN/7W1tP+rq6v/ra2t/87Ozv//////7e3t/7GxsQr/qqqqC/+0tLT/5eXlRf87/9PT0/+v
r6//q6ur/6qqqv+zs7P/7+/v///////Ozs7/ra2t/6urq/+1tbT/SEhN/wAABv8AAAca/wAA
CCv/AAAD/yQkK/+Hh4n/sLCw/6mpqf+5ubn/7Ozs//7+/v/Z2dn/pqamCv+rq6sL/7S0tP/g
4OA9/wv/2NjY/7GxsQr/q6urK/+qqqr/4uLi///////s7Oz/ubm5/6mpqf+wsLD/h4eJ/yQk
K/8AAAMe/wAACC//AAAH/wEBCP9JSU3/srKy/6urq/+srKz/ycnJ///////19fX/xsbG/6am
pgr/q6urD/+wsLD/v7+//+Xl5S3/D//m5ub/vr6+/6+vrwr/q6urL/+mpqb/19fX//v7+///
////ycnJ/6ysrP+rq6v/srKy/0lJTf8BAQj/AAAHIv8AAAhP/wAABP8dHST/fn6A/7Kysv+q
qqr/sLCw/9bW1v//////8vLy/8PDw/+mpqb/q6ur/6qqqv+rq6v/srKy/8LCwv/i4uL/7u7u
//j4+A3/F//6+vr/7Ozs/9/f3//FxcX/srKyDv+rq6sv/6Wlpf/IyMj/9vb2///////W1tb/
sLCw/6qqqv+ysrL/fn6A/x0dJP8AAAQm/wAACAr/AAAHl/89PUL/qqqq/62trf+qqqr/tbW1
/+Hh4f//////8/Pz/83Nzf+rq6v/qKio/6urq/+qqqr/rKys/7Kysv+0tLT/tra2/7i4uP/C
wsL/vLy8/7a2tv+zs7P/sbGx/6ysrP+qqqr/q6ur/6ioqP+rq6v/0dHR//X19f//////4eHh
/7W1tf+qqqr/ra2t/6qqqv89PUIK/wAAByr/AAAIE/8AAAb/CQkR/1ZWWv+zs7IK/6urqyP/
t7e3/+Li4v//////+fn5/+vr6//IyMj/qamp/6ioqBb/qqqqB/+srKwW/6qqqiP/qamp/6io
qP/Hx8f/6+vr//r6+v//////4uLi/7e3twr/q6urE/+zs7L/VlZa/wkJEf8AAAYy/wAACCP/
AAAG/xMTGv9paWz/tra2/6qqqv+rq6v/tbW1/9fX1wn/F//39/f/6Ojo/8XFxf+pqan/pqam
Cv+np6cH/6ioqAr/qampH/+oqKj/p6en/6Wlpf+tra3/wMDA/+Tk5P/29vYJ/yP/19fX/7W1
tf+rq6v/qqqq/7a2tv9paWz/ExMa/wAABjr/AAAIJ/8AAAb/HR0j/3p6fP+3t7f/q6ur/6qq
qv+xsbH/ysrK//Hx8Qn/N//29vb/7u7u/+Xl5f/b29v/0dHR/8fHx/++vr7/v7+//83Nzf/a
2tr/5+fn/+/v7//19fUJ/yf/8fHx/8rKyv+xsbH/qqqq/6urq/+3t7f/enp8/x0dI/8AAAY+
/wAACC//AAAH/wAACP8dHSP/bGxv/7S0s/+srKz/qqqq/62trf+6urr/0NDQ//T09A3/D//9
/f3/+fn5//b29gr/8/PzC//39/f//Pz8Df8v//T09P/Q0ND/urq6/62trf+qqqr/rKys/7S0
s/9sbG//HR0j/wAACP8AAAdC/wAACAr/AAAHL/8UFBv/WFhc/6ysrP+xsbH/qqqq/6mpqf+u
rq7/u7u7/8fHx//c3Nz/8vLyHf8v//Ly8v/c3Nz/x8fH/7u7u/+urq7/qamp/6qqqv+xsbH/
rKys/1hYXP8UFBsK/wAAB0r/AAAIf/8AAAf/AAAG/wsLE/8/P0T/hoaI/7W1tP+vr6//qqqq
/6mpqf+rq6v/s7Oz/7u7u//AwMD/w8PD/8jIyP/Ozs7/yMjI/8PDw//AwMD/u7u7/7Ozs/+r
q6v/qamp/6qqqv+vr6//tbW0/4aGiP8/P0T/CwsT/wAABv8AAAdW/wAACCv/AAAG/wICCv8g
ICb/TExQ/4+Pkf+3t7b/srKx/62trf+qqqr/qampCv+oqKgP/6qqqv+tra3/qqqqCv+oqKgr
/6mpqf+qqqr/ra2t/7Kysf+3t7b/j4+R/0xMUP8gICb/AgIK/wAABmL/AAAIZ/8AAAf/AAAE
/wQEDP8mJiz/Tk5S/3Z2ef+cnJ3/tra2/7S0s/+ysrL/sbGx/7Cwr/+urq7/sLCv/7Gxsf+y
srL/tLSz/7a2tv+cnJ3/dnZ5/05OUv8mJiz/BAQM/wAABP8AAAdu/wAACFf/AAAH/wAABP8D
Awv/GRkg/y4uNP9ISEz/ZGRo/3Bwc/98fH7/h4eJ/5CQkf+Hh4n/fHx+/3Bwc/9kZGj/SEhM
/y4uNP8ZGSD/AwML/wAABP8AAAd+/wAACEf/AAAH/wAABP8AAAL/AAAH/w8PF/8WFh3/HR0k
/yQkKv8pKS//JCQq/x0dJP8WFh3/Dw8X/wAAB/8AAAL/AAAE/wAAB5L/AAAIC/8AAAf/AAAF
Cv8AAAQP/wAAA/8AAAL/AAADCv8AAAQL/wAABf8AAAfipv8AAAg=' readStream) contents! !!SugarNavigatorBar methodsFor: 'help flap'!toggleHelp	PEUtilities openAboutWindow! !!SugarNavigatorBar methodsFor: '*SqueakBot'!makeTheSimpleButtons	^ {self buttonHelp. self makeProjectNameLabel. self buttonPrev. self buttonNext. self buttonPaint. self buttonSqueakBot. self buttonSupplies} , {self buttonLanguage}		, (SugarLauncher isRunningInSugar				ifTrue: [{self buttonShare. #spacer. self buttonChoose. self buttonKeep. self buttonStop}]				ifFalse: [{self buttonZoom. #spacer. self buttonFind. self buttonPublish. self buttonQuit}])		, (Preferences navControlInNavBar				ifTrue: [{self buttonHideNavBar}]				ifFalse: [#()])! !!SugarNavigatorBar methodsFor: '*SqueakBot'!toggleSqueakBot	| t1 t2 |	t2 := Flaps globalFlapTab: 'SqueakBot'.	t1 := t2 referent.	t1 isInWorld		ifTrue: [t2 hideFlap]		ifFalse: [t2 showFlap.			(owner notNil					and: [owner isFlapTab])				ifTrue: [owner edgeToAdhereTo == #top						ifTrue: [t1 position: self bottomLeft].					owner edgeToAdhereTo == #bottom						ifTrue: [t1 bottomLeft: self topLeft]]]! !SqueakBot initialize!