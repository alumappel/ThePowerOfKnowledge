(function (cjs, an) {

var p; // shortcut to reference prototypes
var lib={};var ss={};var img={};
lib.ssMetadata = [
		{name:"loadJSON_atlas_1", frames: [[0,0,859,580],[0,582,771,535],[773,582,32,32]]}
];


(lib.AnMovieClip = function(){
	this.actionFrames = [];
	this.ignorePause = false;
	this.gotoAndPlay = function(positionOrLabel){
		cjs.MovieClip.prototype.gotoAndPlay.call(this,positionOrLabel);
	}
	this.play = function(){
		cjs.MovieClip.prototype.play.call(this);
	}
	this.gotoAndStop = function(positionOrLabel){
		cjs.MovieClip.prototype.gotoAndStop.call(this,positionOrLabel);
	}
	this.stop = function(){
		cjs.MovieClip.prototype.stop.call(this);
	}
}).prototype = p = new cjs.MovieClip();
// symbols:



(lib.Image = function() {
	this.initialize(ss["loadJSON_atlas_1"]);
	this.gotoAndStop(0);
}).prototype = p = new cjs.Sprite();



(lib.logoNew = function() {
	this.initialize(ss["loadJSON_atlas_1"]);
	this.gotoAndStop(1);
}).prototype = p = new cjs.Sprite();



(lib.TextInput = function() {
	this.initialize(ss["loadJSON_atlas_1"]);
	this.gotoAndStop(2);
}).prototype = p = new cjs.Sprite();
// helper functions:

function mc_symbol_clone() {
	var clone = this._cloneProps(new this.constructor(this.mode, this.startPosition, this.loop, this.reversed));
	clone.gotoAndStop(this.currentFrame);
	clone.paused = this.paused;
	clone.framerate = this.framerate;
	return clone;
}

function getMCSymbolPrototype(symbol, nominalBounds, frameBounds) {
	var prototype = cjs.extend(symbol, cjs.MovieClip);
	prototype.clone = mc_symbol_clone;
	prototype.nominalBounds = nominalBounds;
	prototype.frameBounds = frameBounds;
	return prototype;
	}


(lib.Logo = function(mode,startPosition,loop,reversed) {
if (loop == null) { loop = true; }
if (reversed == null) { reversed = false; }
	var props = new Object();
	props.mode = mode;
	props.startPosition = startPosition;
	props.labels = {};
	props.loop = loop;
	props.reversed = reversed;
	cjs.MovieClip.apply(this,[props]);

	// Layer_3
	this.instance = new lib.logoNew();
	this.instance.setTransform(24,-48.15,0.4441,0.4441,17.1722);

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1));

	this._renderFirstFrame();

}).prototype = getMCSymbolPrototype(lib.Logo, new cjs.Rectangle(-46.1,-48.1,397.20000000000005,328.1), null);


(lib.an_TextInput = function(options) {
	this.initialize();
	this._element = new $.an.TextInput(options);
	this._el = this._element.create();
}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(0,0,100,22);

p._tick = _tick;
p._handleDrawEnd = _handleDrawEnd;
p._updateVisibility = _updateVisibility;
p.draw = _componentDraw;



(lib.Symbol1 = function(mode,startPosition,loop,reversed) {
if (loop == null) { loop = true; }
if (reversed == null) { reversed = false; }
	var props = new Object();
	props.mode = mode;
	props.startPosition = startPosition;
	props.labels = {};
	props.loop = loop;
	props.reversed = reversed;
	cjs.MovieClip.apply(this,[props]);

	// Layer_1
	this.text = new cjs.Text("!קדימה", "italic bold 23px 'Calibri'");
	this.text.textAlign = "center";
	this.text.lineHeight = 30;
	this.text.lineWidth = 86;
	this.text.parent = this;
	this.text.setTransform(50.1,5.35);

	this.shape = new cjs.Shape();
	this.shape.graphics.f().s("#663300").ss(1,1,1).p("AopirIRTAAIAAFXIxTAAg");
	this.shape.setTransform(50.575,18.2);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#F6E6D5").s().p("AopCsIAAlWIRTAAIAAFWg");
	this.shape_1.setTransform(50.575,18.2);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_1},{t:this.shape},{t:this.text}]}).wait(1));

	this._renderFirstFrame();

}).prototype = getMCSymbolPrototype(lib.Symbol1, new cjs.Rectangle(-5.8,0.1,112.8,36.3), null);


(lib.forcomb = function(mode,startPosition,loop,reversed) {
if (loop == null) { loop = true; }
if (reversed == null) { reversed = false; }
	var props = new Object();
	props.mode = mode;
	props.startPosition = startPosition;
	props.labels = {};
	props.loop = loop;
	props.reversed = reversed;
	cjs.MovieClip.apply(this,[props]);

	// Layer_1
	this.responeTxt = new cjs.Text("", "18px 'Calibri'", "#FFFFFF");
	this.responeTxt.name = "responeTxt";
	this.responeTxt.textAlign = "center";
	this.responeTxt.lineHeight = 24;
	this.responeTxt.lineWidth = 292;
	this.responeTxt.parent = this;
	this.responeTxt.setTransform(58.5,14);

	this.responeTxt_1 = new cjs.Text("", "18px 'Calibri'", "#FFFFFF");
	this.responeTxt_1.name = "responeTxt_1";
	this.responeTxt_1.textAlign = "center";
	this.responeTxt_1.lineHeight = 24;
	this.responeTxt_1.lineWidth = 292;
	this.responeTxt_1.parent = this;
	this.responeTxt_1.setTransform(58.5,78.2);

	this.gameCode_txt = new lib.an_TextInput({'id': 'gameCode_txt', 'value':'', 'disabled':false, 'visible':true, 'class':'ui-textinput'});

	this.gameCode_txt.name = "gameCode_txt";
	this.gameCode_txt.setTransform(58.1,-23.8,1.5403,1.4091,0,0,0,49.9,10.8);

	this.play_btn = new lib.Symbol1();
	this.play_btn.name = "play_btn";
	this.play_btn.setTransform(59.7,56.8,1.2998,1.0676,0,0,0,52.4,17.3);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.play_btn},{t:this.gameCode_txt},{t:this.responeTxt_1},{t:this.responeTxt}]}).wait(1));

	this._renderFirstFrame();

}).prototype = getMCSymbolPrototype(lib.forcomb, new cjs.Rectangle(-89.5,-39.7,296,141.9), null);


(lib.comboBG = function(mode,startPosition,loop,reversed) {
if (loop == null) { loop = true; }
if (reversed == null) { reversed = false; }
	var props = new Object();
	props.mode = mode;
	props.startPosition = startPosition;
	props.labels = {};
	props.loop = loop;
	props.reversed = reversed;
	cjs.MovieClip.apply(this,[props]);

	// Layer_1
	this.text = new cjs.Text("קודים לדוגמה: 100,101", "bold 12px 'Calibri'", "#666666");
	this.text.textAlign = "center";
	this.text.lineHeight = 17;
	this.text.lineWidth = 259;
	this.text.parent = this;
	this.text.setTransform(428.5,419.25);

	this.instance = new lib.Logo();
	this.instance.setTransform(438.1,132.05,0.9597,0.9597,-5.2499,0,0,152.5,116);

	this.text_1 = new cjs.Text("היי, אני קיטי \nאני פה כדי לעזור לכם ללמוד\nהקלידו קוד משחק", "bold 27px 'Calibri'");
	this.text_1.textAlign = "center";
	this.text_1.lineHeight = 35;
	this.text_1.lineWidth = 314;
	this.text_1.parent = this;
	this.text_1.setTransform(430,276.25);

	this.instance_1 = new lib.Image();

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_1},{t:this.text_1},{t:this.instance},{t:this.text}]}).wait(1));

	this._renderFirstFrame();

}).prototype = getMCSymbolPrototype(lib.comboBG, new cjs.Rectangle(0,-42.2,859,622.2), null);


// stage content:
(lib.loadJSON = function(mode,startPosition,loop,reversed) {
if (loop == null) { loop = true; }
if (reversed == null) { reversed = false; }
	var props = new Object();
	props.mode = mode;
	props.startPosition = startPosition;
	props.labels = {};
	props.loop = loop;
	props.reversed = reversed;
	cjs.MovieClip.apply(this,[props]);

	this.actionFrames = [0];
	this.isSingleFrame = false;
	// timeline functions:
	this.frame_0 = function() {
		if(this.isSingleFrame) {
			return;
		}
		if(this.totalFrames == 1) {
			this.isSingleFrame = true;
		}
		////---------------------התחלה
		
		            var myJSON;
		            var AllTheContent = [
		                ["בחר נושא משחק"],
		                [
		                    ["", "", "", ""]
		
		                ]
		            ]
		
		           // var lq = new createjs.LoadQueue(true);
		           // lq.addEventListener('complete', loadJSON);
		           // lq.loadFile({ id: "json", type: "json", src: "response125.txt" });
		
		           // function loadJSON(event) {
		           //     myJSON = event.target.getResult('json');
		           //     LoadJSONToArry();
		           // }
		
		           // function LoadJSONToArry() {
		           //     console.log(myJSON);
		           //     ///דברים כלליים של המשחק
		           //     //נושא
		           //     AllTheContent[1][0][0] = myJSON.gameTopic;
		           //     //הנחייה
		           //     AllTheContent[1][0][1] = myJSON.gameQuestionText;
		           //     //סוג טקסט/ תמונה
		           //     if (myJSON.gameQuestionImge != null) {
		           //         AllTheContent[1][0][2] = "text and imeg";
		           //     }
		           //     else {
		           //         AllTheContent[1][0][2] = "text";
		           //     }
		
		           //     //מקור של תמונה
		           //     if (AllTheContent[1][0][2] == "text and imeg")
		           //         AllTheContent[1][0][3] = myJSON.gameQuestionImge;
		
		           //     ///הכנסת פריטים
		           //     for (i = 0; i < myJSON.gameAnswers.length; i++) {
		           //         var Item = [];
		           //         //תוכן
		           //         Item[0] = myJSON.gameAnswers[i].content;                 
					        ////האם נכון
		           //         Item[1] = myJSON.gameAnswers[i].correctAnswer;
					        ////סוג
		           //         if (myJSON.gameAnswers[i].haveImge == false) {
		           //             Item[2] = "text";
		           //         }
		           //         else {
		           //             Item[2] = "imeg";
		           //         }
					        ////האם טעו בו
		           //         Item[3] = "no mistake";
		           //         AllTheContent[1].push(Item);
		           //     }
		           //     console.log(" המערך שלי2");
		           //     console.log(AllTheContent);
		           // }
		
		
		var url = "api/Games/byCode/";
		

		//nohars combobox

		var comboBG = new lib.comboBG();
		comboBG.x = 210;
		comboBG.y = 35;
		comboBG.scale = 0.5;
		stage.addChild(comboBG);

		var forcombo = new lib.forcomb();
		forcombo.x = 285;
		forcombo.y = 255;
		stage.addChild(forcombo);
		forcombo.scale = 0.5;
		forcombo.play_btn.alpha = 0.3;
		$("#dom_overlay_container").on("keyup", "#gameCode_txt", codeInput_change);

		function codeInput_change(evt) {
			//שמירת הערך שנבחר בקומבו
			gameCodeUser = evt.currentTarget.value;
			forcombo.play_btn.alpha = 1;
			/*forcombo.play_btn.addEventListener("click", initProgram);*/
			forcombo.play_btn.addEventListener("click", getTheGame);

		}

		
		

		async function getTheGame() {

			//משיכת קוד המשחק שהוקלד בתיבת הטקסט
			var code = gameCode_txt.value;

			//fetch = שיטה הקיימת בג'אווה סקריפט המאפשר לבצע קריאות רשת ולקרוא את התשובות החוזרות מהן
			//משתנה המכיל את כל תשובת הרשת שחוזרת מהקריאה לנתיב שהוגדר
			var response = await fetch(url + code);

			//אם הקריאה הסתיימה והחזירה משחק תקין
			if (response.ok) {

				//חילוץ המידע של המשחק מקריאת הרשת בפורמט של ג'ייסון
				myJSON = await response.json();
				console.log(myJSON);
				//המירו את הג'ייסון למערך שמתאים למשחק שלכם והפעילו את המשחק
				LoadJSONToArry();
			}
			//אם הקריאה הסתיימה בתשובה שאינה תקינה (כלומר שגיאה)
			else {

				//חילוץ תוכן התשובה עצמה שחזרה מהקריאה = התוכן שכתבנו בתוך הסוגריים במחולל
				var error = await response.text();

				if (error == "Game not publish") {
					console.log("משחק קיים אך לא פורסם");
				}
				else if (error == "Game not found") {
					console.log("המשחק שחיפשת אינו קיים");
				}
				else {
					console.log("אירעה תקלת שרת, נסו שוב");
					console.log(error);
				}
			}
		}



	var gameCodeUser; //משתנה לשמירת קוד המשחק שהמשתמש הקליד
		//function initProgram() {
		//	//gameCodeUser = gameCode_txt.value; //שמירת הערך שהוקלד בתיבת הטקסט

		//	$.post("Handler.ashx", { //פנייה לקובץ ההנדלר בשרת
		//		gameCode: gameCodeUser //שליחת קוד המשחק לשרת
		//	})
		//		.done(function (response) { //אם הפנייה הצליחה וחזרה תשובה

		//			if (response == "noGameFound") { //אם התשובה היא שלא קיים משחק
		//				forcombo.responeTxt.text = "המשחק לא קיים";
		//				console.log("game does not exist")
		//			} else if (response == "notpublish") //אם קיים משחק
		//			{
		//				console.log("not publish");
		//				//אם התשובה היא שלא מפורסם
		//				forcombo.responeTxt.text = "המשחק לא מפורסם";
		//			} else { //אם המשחק מפורסם
		//				forcombo.responeTxt.text = "";
		//				myJSON = JSON.parse(response); //המרת הטקסט שחזר במבנה ג'ייסון למשתנה מסוג ג'ייסון
		//				console.log(myJSON);
		//				LoadJSONToArry(); //הפונקציה שממירה את הג'ייסון למערך
		//			}
		//		})
		//		.fail(function () {
		//			forcombo.responeTxt.text = "יש בעיית תקשורת, נסה שוב";
		//			console.log("error");
		//		})
		//}



		function LoadJSONToArry() {
			
			///דברים כלליים של המשחק
			//נושא
			AllTheContent[1][0][0] = myJSON.gameTopic;
			//הנחייה
			AllTheContent[1][0][1] = myJSON.gameQuestionText;
			//סוג טקסט/ תמונה
			if (myJSON.gameQuestionImge != null) {
				AllTheContent[1][0][2] = "text and imeg";
			}
			else {
				AllTheContent[1][0][2] = "text";
			}

			//מקור של תמונה
			if (AllTheContent[1][0][2] == "text and imeg")
				AllTheContent[1][0][3] = myJSON.gameQuestionImge;

			///הכנסת פריטים
			for (i = 0; i < myJSON.gameAnswers.length; i++) {
				var Item = [];
				//תוכן
				Item[0] = myJSON.gameAnswers[i].content;
				//האם נכון
				Item[1] = myJSON.gameAnswers[i].correctAnswer;
				//סוג
				if (myJSON.gameAnswers[i].haveImge == false) {
					Item[2] = "text";
				}
				else {
					Item[2] = "imeg";
				}
				//האם טעו בו
				Item[3] = "no mistake";
				AllTheContent[1].push(Item);
			}
			console.log(" המערך שלי2");
			console.log(AllTheContent);
		}




            /////////////-------------סוף
	}

	// actions tween:
	this.timeline.addTween(cjs.Tween.get(this).call(this.frame_0).wait(1));

	this._renderFirstFrame();

}).prototype = p = new lib.AnMovieClip();
p.nominalBounds = new cjs.Rectangle(0,0,0,0);
// library properties:
lib.properties = {
	id: '63AE204ED5AA0F49A471A5F62B278047',
	width: 640,
	height: 480,
	fps: 24,
	color: "#FFFFFF",
	opacity: 1.00,
	manifest: [
		{src:"images/loadJSON_atlas_1.png?1657025197739", id:"loadJSON_atlas_1"},
		{src:"https://code.jquery.com/jquery-3.4.1.min.js?1657025197769", id:"lib/jquery-3.4.1.min.js"},
		{src:"components/sdk/anwidget.js?1657025197769", id:"sdk/anwidget.js"},
		{src:"components/ui/src/textinput.js?1657025197769", id:"an.TextInput"}
	],
	preloads: []
};



// bootstrap callback support:

(lib.Stage = function(canvas) {
	createjs.Stage.call(this, canvas);
}).prototype = p = new createjs.Stage();

p.setAutoPlay = function(autoPlay) {
	this.tickEnabled = autoPlay;
}
p.play = function() { this.tickEnabled = true; this.getChildAt(0).gotoAndPlay(this.getTimelinePosition()) }
p.stop = function(ms) { if(ms) this.seek(ms); this.tickEnabled = false; }
p.seek = function(ms) { this.tickEnabled = true; this.getChildAt(0).gotoAndStop(lib.properties.fps * ms / 1000); }
p.getDuration = function() { return this.getChildAt(0).totalFrames / lib.properties.fps * 1000; }

p.getTimelinePosition = function() { return this.getChildAt(0).currentFrame / lib.properties.fps * 1000; }

an.bootcompsLoaded = an.bootcompsLoaded || [];
if(!an.bootstrapListeners) {
	an.bootstrapListeners=[];
}

an.bootstrapCallback=function(fnCallback) {
	an.bootstrapListeners.push(fnCallback);
	if(an.bootcompsLoaded.length > 0) {
		for(var i=0; i<an.bootcompsLoaded.length; ++i) {
			fnCallback(an.bootcompsLoaded[i]);
		}
	}
};

an.compositions = an.compositions || {};
an.compositions['63AE204ED5AA0F49A471A5F62B278047'] = {
	getStage: function() { return exportRoot.stage; },
	getLibrary: function() { return lib; },
	getSpriteSheet: function() { return ss; },
	getImages: function() { return img; }
};

an.compositionLoaded = function(id) {
	an.bootcompsLoaded.push(id);
	for(var j=0; j<an.bootstrapListeners.length; j++) {
		an.bootstrapListeners[j](id);
	}
}

an.getComposition = function(id) {
	return an.compositions[id];
}


an.makeResponsive = function(isResp, respDim, isScale, scaleType, domContainers) {		
	var lastW, lastH, lastS=1;		
	window.addEventListener('resize', resizeCanvas);		
	resizeCanvas();		
	function resizeCanvas() {			
		var w = lib.properties.width, h = lib.properties.height;			
		var iw = window.innerWidth, ih=window.innerHeight;			
		var pRatio = window.devicePixelRatio || 1, xRatio=iw/w, yRatio=ih/h, sRatio=1;			
		if(isResp) {                
			if((respDim=='width'&&lastW==iw) || (respDim=='height'&&lastH==ih)) {                    
				sRatio = lastS;                
			}				
			else if(!isScale) {					
				if(iw<w || ih<h)						
					sRatio = Math.min(xRatio, yRatio);				
			}				
			else if(scaleType==1) {					
				sRatio = Math.min(xRatio, yRatio);				
			}				
			else if(scaleType==2) {					
				sRatio = Math.max(xRatio, yRatio);				
			}			
		}
		domContainers[0].width = w * pRatio * sRatio;			
		domContainers[0].height = h * pRatio * sRatio;
		domContainers.forEach(function(container) {				
			container.style.width = w * sRatio + 'px';				
			container.style.height = h * sRatio + 'px';			
		});
		stage.scaleX = pRatio*sRatio;			
		stage.scaleY = pRatio*sRatio;
		lastW = iw; lastH = ih; lastS = sRatio;            
		stage.tickOnUpdate = false;            
		stage.update();            
		stage.tickOnUpdate = true;		
	}
}
function _updateVisibility(evt) {
	var parent = this.parent;
	var detach = this.stage == null || this._off || !parent;
	while(parent) {
		if(parent.visible) {
			parent = parent.parent;
		}
		else{
			detach = true;
			break;
		}
	}
	detach = detach && this._element && this._element._attached;
	if(detach) {
		this._element.detach();
		this.dispatchEvent('detached');
		stage.removeEventListener('drawstart', this._updateVisibilityCbk);
		this._updateVisibilityCbk = false;
	}
}
function _handleDrawEnd(evt) {
	if(this._element && this._element._attached) {
		var props = this.getConcatenatedDisplayProps(this._props), mat = props.matrix;
		var tx1 = mat.decompose(); var sx = tx1.scaleX; var sy = tx1.scaleY;
		var dp = window.devicePixelRatio || 1; var w = this.nominalBounds.width * sx; var h = this.nominalBounds.height * sy;
		mat.tx/=dp;mat.ty/=dp; mat.a/=(dp*sx);mat.b/=(dp*sx);mat.c/=(dp*sy);mat.d/=(dp*sy);
		this._element.setProperty('transform-origin', this.regX + 'px ' + this.regY + 'px');
		var x = (mat.tx + this.regX*mat.a + this.regY*mat.c - this.regX);
		var y = (mat.ty + this.regX*mat.b + this.regY*mat.d - this.regY);
		var tx = 'matrix(' + mat.a + ',' + mat.b + ',' + mat.c + ',' + mat.d + ',' + x + ',' + y + ')';
		this._element.setProperty('transform', tx);
		this._element.setProperty('width', w);
		this._element.setProperty('height', h);
		this._element.update();
	}
}

function _tick(evt) {
	var stage = this.stage;
	stage&&stage.on('drawend', this._handleDrawEnd, this, true);
	if(!this._updateVisibilityCbk) {
		this._updateVisibilityCbk = stage.on('drawstart', this._updateVisibility, this, false);
	}
}
function _componentDraw(ctx) {
	if(this._element && !this._element._attached) {
		this._element.attach($('#dom_overlay_container'));
		this.dispatchEvent('attached');
	}
}
an.handleSoundStreamOnTick = function(event) {
	if(!event.paused){
		var stageChild = stage.getChildAt(0);
		if(!stageChild.paused || stageChild.ignorePause){
			stageChild.syncStreamSounds();
		}
	}
}
an.handleFilterCache = function(event) {
	if(!event.paused){
		var target = event.target;
		if(target){
			if(target.filterCacheList){
				for(var index = 0; index < target.filterCacheList.length ; index++){
					var cacheInst = target.filterCacheList[index];
					if((cacheInst.startFrame <= target.currentFrame) && (target.currentFrame <= cacheInst.endFrame)){
						cacheInst.instance.cache(cacheInst.x, cacheInst.y, cacheInst.w, cacheInst.h);
					}
				}
			}
		}
	}
}


})(createjs = createjs||{}, AdobeAn = AdobeAn||{});
var createjs, AdobeAn;