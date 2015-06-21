/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve(start, end) {
	var i,
		result=[],
		isPrime = true,
		j;

	if (typeof(start) === 'undefined' || typeof(end) === 'undefined') {
		throw new Error();
	}

	start= +start;
	end= +end;


	for(i=start; i<=end; i+=1){

		isPrime=true;

		for(j=2; j <= Math.sqrt(i); j+=1){
			if (!(i%j)){
				isPrime = false;
				break;
			}
		}
		if (isPrime && i > 1) {
			result.push(i);
		}
		
	}
return result;
}

module.exports = solve;