function arrayOperation(array){
	var i,
		len;
	for(i=0, len=array.length; i<len;i++){
		array[i]=5*i;
	}
	return array;
}

var array = [];
array.length=20;
document.getElementById("print").addEventListener("click", function(){
	document.getElementById("result").innerHTML = arrayOperation(array);
});
