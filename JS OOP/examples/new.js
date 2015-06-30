var Animal = (function(){
	function Animal(color){
		this.color =  color;
	}

	Animal.prototype.toString = function(){
		return this.color;
	}

	return Animal;
}());


var Cat = (function(parent){
	function Cat(color, name){
		parent.call(this, color);
		this.name = name;
	}

	Cat.prototype = parent.prototype;

	Cat.prototype.toString = function(){
		return parent.prototype.toString.call(this) + " " + this.name;
	}
	return Cat;
}(Animal));
var pesho = new Animal("blue");
console.log(pesho.toString());
console.log(pesho.__proto__);
var cat = new Cat("blue", "CAT");
console.log(cat.toString())

