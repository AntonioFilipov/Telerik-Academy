function replace(s) {
	return s.split(" ").join("&nbsp;");
}

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
document.getElementById("input").innerHTML=text;

document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= "See console";
	console.log(replace(text));
});