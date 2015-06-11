function parse(s) {
	var protocol = s.substring(0, s.indexOf('://')),
		server = s.substring(s.indexOf('://')+3, s.indexOf('/',s.indexOf('://')+3)),
		resource = s.substring(s.indexOf('/',s.indexOf('://')+3)),
		obj={
			'protocol':protocol,
			'server':server,
			'resource':resource
		};
	return obj;
}

var text = "http://telerikacademy.com/Courses/Courses/Details/239";
document.getElementById("input").innerHTML= text;
document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= JSON.stringify(parse(text), null, 4);
	console.log(parse(text));
});