function sort(array){
	var i,
		j,
		len,
		min,
		indexOfMin,
		valueOfMin;
	for(i=0, len=array.length-1; i<len;i++){
		min=array[i];
		indexOfMin=i;
		for(j=i+1, len=array.length; j<len;j++){
			if (array[j] < min) {
				min=array[j];
				indexOfMin = j;
			}
		}
		temp = array[i];
		array[i] = min;
		array[indexOfMin] = temp;
	}
	return array;
}

var array = [0,9,8,7,6,6,-3,5,4,3,2,1];
document.getElementById("input").innerHTML = array;
document.getElementById("print").addEventListener("click", function(){
	document.getElementById("result").innerHTML = sort(array);
});

