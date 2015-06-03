function comparison(array1,array2){
	var i,
		len,
		isArray1First;
	for(i=0, len=array1.length; i<len;i++){
		if(array1[i] > array2[i]){
			isArray1First = false;
			break;
		}else if(array1[i] < array2[i]){
			isArray1First = true;
			break;
		}
	}
	if (isArray1First) {
		return "first array is first lexicographically";
	}else{
		return "second array is first lexicographically";
	}
}

var array1 = ['b','c','g'];
var array2 = ['b','f'];
document.getElementById("input").innerHTML = 'Array 1:'+array1 + ' Array2:'+array2;
document.getElementById("print").addEventListener("click", function(){
	document.getElementById("result").innerHTML = comparison(array1, array2);
});
