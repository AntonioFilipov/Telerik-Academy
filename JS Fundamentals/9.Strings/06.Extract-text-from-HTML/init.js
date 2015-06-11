function replace(s) {
	var i,
		len,
		inTag=false,
		result='';
	for(i=0, len=s.length; i< len; i+=1){
		if (s[i] === '<') {
			inTag = true;
		}else if(s[i] === '>'){
			inTag=false;
			continue;
		}

		if (!inTag) {
			result+=s[i];
		};
	}
	return result;
}

var text = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";
document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= replace(text);
	console.log(text);
});