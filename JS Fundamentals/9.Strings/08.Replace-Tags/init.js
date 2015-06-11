function replace(string) {
  var output = string;
    var counter = 0;
    while (output.indexOf('<a href="', counter) > 0) {
        output = output.replace('<a href="', '[URL=');
        counter++;
    }
    counter = 0;
    while (output.indexOf('">', counter) > 0) {
        output = output.replace('">', ']');
        counter++;
    }
    counter = 0;
    while (output.indexOf('</a>', counter) > 0) {
        output = output.replace('</a>', '[/URL]');
        counter++;
    }
    return output;
}

var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
document.getElementById("input").innerHTML= text;
document.getElementById("check").addEventListener("click", function(){
	// document.getElementById("result").innerHTML= JSON.stringify(parse(text), null, 4);
	document.getElementById("input").innerHTML+= '\n' + 'See console!';
	console.log(replace(text));
});