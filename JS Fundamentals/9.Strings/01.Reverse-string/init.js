function reverse(s) {
  return s.split('').reverse().join('');
}

document.getElementById("check").addEventListener("click", function(){
	var input = document.getElementById("input").value;
	document.getElementById("result").innerHTML='Reversed: '+reverse(input);
});