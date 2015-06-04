function count(array, num){
	var i,
		len,
		number=+num,
		counter=0;
	for(i=0, len=array.length; i<len;i++){
		if (array[i] === number) {
			counter+=1;
		};
	}
	return counter;
}

var array = [4,0,9,8,7,6,6,-3,5,4,4,4,3,2,1,4],
	number;
document.getElementById("input").innerHTML = array;
document.getElementById("print").addEventListener("click", function(){
	number = document.getElementById("number").value;
	document.getElementById("result").innerHTML = count(array, number) + ' times';
});

