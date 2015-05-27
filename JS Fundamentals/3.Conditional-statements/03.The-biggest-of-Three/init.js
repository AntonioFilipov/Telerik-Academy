function check(a,b,c){
	var a = a|0;
	var b = b|0;
	var c =  c|0;
	if (a>b) {
		if (a>c) {
			return a;
		};
	}
	if(b>a){
		if (b>c) {
			return b;
		};
	}

	return c;
	
}

document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var inputb=document.getElementById('b').value;
	var inputc=document.getElementById('c').value;
	var result = document.getElementById('result').innerHTML = check(inputa,inputb,inputc);
});

