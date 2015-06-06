function checkForProperty(object, property){
    if (object.hasOwnProperty(property)) {
        return true;
    }
    return false;
}

var arr=[1,2,3];
document.getElementById("input").innerHTML= arr + "  is  " + typeof arr;
document.getElementById("check").addEventListener('click', function(){
	document.getElementById("result").innerHTML = "Check for property \"length\":"+checkForProperty(arr,"length") + "<br>"
													+ "Check for property \"unknownPrototype\":"+checkForProperty(arr,"unknownPrototype") ;
});
