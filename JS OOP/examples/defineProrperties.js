var animal = (function(){
	var animal = {};
	Object.defineProperties(animal,{
		init:{
			value:function(type){
				this.type = type;
			}
		},
		toString:{
			value:function(){
				return this.type;
			}
		}
	})
	return animal;
}());


var dog = (function(parent){
	var dog = Object.create(parent);
	Object.defineProperties(dog,{
		init:{
			value:function(type, name){
				parent.init.call(this, type);
				this.name = name;
			}
		},
		toString:{
			value:function(){
				return parent.toString.call(this) + " "+this.name;
			}
		}
	})
	return dog;
}(animal))

var sharo = Object.create(dog);
sharo.init("kuche", "sharo");
console.log(sharo.toString());