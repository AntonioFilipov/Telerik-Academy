function deepCopy(object){
	var copy = JSON.parse(JSON.stringify(object));
	return copy;
}

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'],
	number = 1,
	copyArr=deepCopy(arr),
	copyNumber=deepCopy(number);
copyArr.push("test");
copyNumber = 5;


document.getElementById("check").addEventListener('click', function(){
	document.getElementById("input").innerHTML = "Original object:["+arr+"]<br>"+"Original number:"+number;
	document.getElementById("result").innerHTML = "Copied object(add \"test\"):["+copyArr+"]<br>"+"Copied number(changed to 5):"+copyNumber;
});
