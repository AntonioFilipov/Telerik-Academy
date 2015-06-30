var animal = (function(){
	var animal = {
		init:function(type){
			this.type = type;
			// return this;
		},
		toString: function(){
			return this.type;
		}
	};
	return animal;
}());

var dog = (function(parent){
	var dog = Object.create(parent);
	dog.init = function(type, name){
		parent.init.call(this, type);
		this.name = name;
		return this;
	};

	dog.bark = function(){
		return this.name + ' barks';
	};

	dog.toString = function(){
		return parent.toString.call(this) + ' ' + this.name;
	};

	// var dog = Object.defineProperties(parent, {
	// 	init:{
	// 		value:function(type, name){
	// 			parent.init.call(this, "hgo");
	// 			this.name = name;
	// 			// return this;
	// 		}
	// 	},
	// 	bark:{
	// 		value:function(){
	// 			return this.name + ' barks';
	// 		}
	// 	},
	// 	toString:{
	// 		value:function(){
	// 			return parent.toString.call(this) + ' ' + this.name;
	// 		}
	// 	}
	// });

	return dog;
}(animal));


var sharo = Object.create(dog).init("dog","sharo");
console.log(sharo.bark());
console.log(sharo.toString());