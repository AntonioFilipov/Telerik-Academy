function count(){
	var count = document.getElementsByTagName('div').length;
	return count;
}

document.getElementById("print").addEventListener("click", function(){
	document.getElementById("result").innerHTML = count() + ' times';
});
