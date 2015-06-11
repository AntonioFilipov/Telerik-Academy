function check(s) {
	var i,
		len,
		count=0;
	for(i=0, len=s.length; i<len;i++){
		if (s[i] === '(') {
			count+=1;
		}else if (s[i] === ')') {
			count-=1;
		}

		if (count < 0) {
			return "Incorrect";
		}
	}

	if (!count) {
		return "Correct";
	}
	return "Incorrect";
}

var expression = "((a+b)/5-d)";
document.getElementById("input").innerHTML=expression;

document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML=check(expression);
});