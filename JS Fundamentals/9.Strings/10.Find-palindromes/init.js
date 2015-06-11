function palindromes(s) {
	var result = s.replace(/[.,!?]/g,'').split(' ').filter(function(item){
		return item === item.split('').reverse().join('');
	});
	return result;
}

var text = "Lorem lamal dolor sit amet, consectetur adipisicing ABBA abo maiores earum autem quis atque in@gmail.com tempora possimus exe, illo sapiente.";
document.getElementById("input").innerHTML= text;
document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= '['+palindromes(text)+']';
	console.log(palindromes(text));
});