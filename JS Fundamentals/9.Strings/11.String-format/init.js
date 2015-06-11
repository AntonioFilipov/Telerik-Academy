function stringFormat() {
    var result = arguments[0],
    counter;
    for (var i = 0; i < arguments.length - 1; i++) {
        counter = 0;
        while (result.indexOf('{' + i + '}', counter) >= 0) {
            result = result.replace('{' + i + '}', arguments[i + 1]);
            counter += 1;
        }
    }
    return result;
}

document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= stringFormat('Hello {0}!', 'Peter');
});