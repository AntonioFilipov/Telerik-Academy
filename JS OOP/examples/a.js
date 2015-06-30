var animal = (function(){
	var animal = {};

	animal.init = function(type){
		this.type = type;
	};

	animal.toString = function(){
		return "Type: " + this.type;
	};

	animal.makeNoise = function(){
		return "Blalla";
	}
	return animal;
}());

var dog = (function(parent){
	var dog = Object.create(animal);
	dog.init = function(type, name, age){
		parent.init.call(this, type);
		this.name = name;
		this.age = age;
		return this;
	};

	dog.toString = function(){
		return parent.toString.call(this) + " Name: " + this.name + " Age: "+this.age;
	};
	return dog;
}(animal));


var sharo = Object.create(dog).init("dog", "sharo", 3);
console.log(sharo.toString());
