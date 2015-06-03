function find(array){
	var i,
		len,
		resultArray=[],
		position;
		max = Number.MIN_VALUE;
	for(i=0, len=array.length; i<len;i+=1){
		resultArray[array[i]] = 0;
	}

	for(i=0, len=array.length; i<len;i+=1){
		resultArray[array[i]]+=1;
	}

	for(i=0, len=resultArray.length; i<len;i+=1){
		console.log(max);
		if (resultArray[i] !== undefined && resultArray[i] > max) {
				max = resultArray[i];
				position=i;
		};

	}
	return [position, max];
}

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1,1,1,1, 2, 4, 9, 3];
document.getElementById("input").innerHTML = array;
document.getElementById("print").addEventListener("click", function(){
	document.getElementById("result").innerHTML = find(array)[0];
	document.getElementById("result1").innerHTML = '('+find(array)[1]+' times)';
});

