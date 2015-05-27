function iteration(number){
	var number = +number;
	var result='',
		i;
	for(i=1; i<=number;i+=1){
		result+=i+' ';
	}
	return result;
}

document.getElementById('check').addEventListener('click', function() {
	console.log("clic");
	var input = document.getElementById("input").value;
	document.getElementById("result").innerHTML=iteration(+input);
});

