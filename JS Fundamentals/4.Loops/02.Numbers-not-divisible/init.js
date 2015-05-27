function iteration(number){
	var number = +number;
	var result='',
		i;
	for(i=1; i<=number;i+=1){
		if (i%3!==0 && i%7!==0) {
			result+=i+' ';
		};
	}
	return result;
}

document.getElementById('check').addEventListener('click', function() {
	console.log("clic");
	var input = document.getElementById("input").value;
	document.getElementById("result").innerHTML=iteration(+input);
});

