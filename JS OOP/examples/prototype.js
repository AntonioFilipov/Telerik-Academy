var animal = {
	name:"animal"
};

Object.defineProperty(animal.prototype, "name");
console.log(Object.getPrototypeOf(animal));