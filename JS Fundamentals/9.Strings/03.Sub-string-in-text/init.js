function sub(s, substr) {
	var index=s.indexOf(substr),
		counter = 0;
	while(index >= 0){
		counter+=1;
		index = s.indexOf(substr,index+1);
	}
	return counter;
}

var text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
var substr = "in";
document.getElementById("input").innerHTML=text;

document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= substr+" - "+sub(text, substr)+" times.";
});