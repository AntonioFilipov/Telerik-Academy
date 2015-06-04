function checkFirst(arr){
	var i,
		len;
	for(i=1, len=arr.length-1; i<len;i++){
		if (check(arr,i)) {
			return i;
		}
	}
	return 1;
}

var array = [4,8,1, 4, 2, 3, 4, 4, 1,1,1,1, 2, 4, 9, 3],
	position;
document.getElementById("input").innerHTML = array;
document.getElementById("print").addEventListener("click", function(){
	document.getElementById("result").innerHTML = 'Element at position: '+checkFirst(array);
});

