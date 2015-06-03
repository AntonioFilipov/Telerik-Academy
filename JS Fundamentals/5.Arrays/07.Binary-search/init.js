function binarySearch(arr, number){
	var i,
		len,
		array = arr.sort(),
		isFind=false;
		console.log(array);
	while (!isFind){
		
		if (number < array[array.length/2]) {
			array.splice(array.length/2);
			console.log(array);
		}else if (number > array[array.length/2]) {
			array.splice(0, array.length/2);
			console.log(array);
		}else if (number === array[array.length/2]){
			isFind = true;
			console.log(array[array.length/2]);
			break;
		}else{
			break;
		}
	}
	if (isFind) {
		return "Found";
	}else{
		return "Not Found";
	}

}

var array = [8, 7, 6, 4, 3, 2, 1, 0],
	number;

document.getElementById("print").addEventListener("click", function(){
	number = document.getElementById("input").value;
	console.log(number);
	document.getElementById("result").innerHTML = binarySearch(array, number | 0) + '!   Open console F12 for more details!';
});

