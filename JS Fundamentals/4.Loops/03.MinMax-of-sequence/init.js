function maxNumber(numbers){
	var max = +numbers[0];
	for(var i in numbers){
		numbers[i] = +numbers[i];
		if (numbers[i] > max) {
			max = numbers[i];
		};
	}
	return 'Max:'+max;
}

function minNumber(numbers){
	var min = +numbers[0];
	for(var i in numbers){
		numbers[i] = +numbers[i];
		if (numbers[i] < min) {
			min = numbers[i];
		};
	}
	return 'Min:'+min;
}

document.getElementById('check').addEventListener('click', function() {
	
	var input = document.getElementById("input").value.split(',');
	console.log(input);
	document.getElementById("result").innerHTML=maxNumber(input)+'   '+minNumber(input);
});

