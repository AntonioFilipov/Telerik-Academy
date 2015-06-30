var Person = (function(){
	function Person(name, age){
		this.name=name;
		this.age=age;
	}

	Object.defineProperty(Person.prototype,"name",{
		get:function(){
			return this._name;
		},
		set:function(value){
			if (typeof(value) != "string") {
				throw Error("Invalid name");
			}
			this._name = value;
		}
	});
	Person.prototype.introduce = function(){
		return this.name + " " + this.age;
	};

	return Person;

}());

var Student = (function(parent){
	function Student(name, age, number){
		parent.call(this, name, age);
		this.number = number;
	}

	Student.prototype.introduce = function(){
		return parent.prototype.introduce.call(this) + " " + this.number;
	}

	return Student;
}(Person));

var a = new Person("toni", 14);
var b = new Student("moni", 13, 131);
console.log(a.introduce());
console.log(b.introduce())