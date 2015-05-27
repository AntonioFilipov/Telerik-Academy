function exchange(a,b){
	var a=+a;
	var b=+b;
	var temp = a;
	if (b>a) {
		a=b;
		b=temp;
	}
	return 'a='+a+'; '+'b='+b;
}

document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var inputb=document.getElementById('b').value;
	var result = document.getElementById('result').innerHTML = exchange(inputa, inputb);
	
});

