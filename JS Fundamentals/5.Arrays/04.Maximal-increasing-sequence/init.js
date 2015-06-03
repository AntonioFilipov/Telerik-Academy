function max(array){
	var i,
		len,
		maxSequence=0,
		tempSequence=0,
		tempPosition,
		finalPosition;
	for(i=0, len=array.length-1; i<len;i++){
		if (array[i] < array[i+1]) {
			tempSequence+=1;
			tempPosition=i+1;
		}else{
			tempSequence=0;
		}
		if (tempSequence >= maxSequence) {
			maxSequence = tempSequence;
			finalPosition=tempPosition;
		}
	}
	return array.slice(finalPosition - maxSequence, finalPosition+1);
}

var array = [1,2,3,3,3,4,3,4,5,6];
document.getElementById("input").innerHTML = array;
document.getElementById("print").addEventListener("click", function(){
	document.getElementById("result").innerHTML = max(array);
});
