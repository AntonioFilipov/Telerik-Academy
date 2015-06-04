var array = [4, 1, 1, 4, 2, 3, 4, 4, 1,1,1,1, 2, 4, 9, 3],
	position;
document.getElementById("input").innerHTML = array;
document.getElementById("print").addEventListener("click", function(){
	position = document.getElementById("number").value;
	document.getElementById("result").innerHTML = check(array, +position);
});

