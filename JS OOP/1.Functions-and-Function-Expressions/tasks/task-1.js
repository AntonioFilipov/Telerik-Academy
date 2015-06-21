/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {
	var array = arr.map(Number);
	var s = 0;

	if (arr.length === 0) {
    	return null;
	}

	if (arr === undefined || sum.length === 0 || !array.map(Number)) {
		throw Error();
	}


	array.forEach(function(i){
		if (isNaN(i)) {
			throw Error();
		}
		s+=i;
	});
	return s;
}

module.exports = sum;