function sort(a,b,c){
	var a = a|0;
	var b = b|0;
	var c = c|0;
	if (a>b && a>c) {
		console.log(a);
		if (b>c) {
			console.log(b);
			console.log(c);
		}else{
			console.log(c);
			console.log(b);		
		};
	}else if(b>a && b>c){
		console.log(b);
		if (a>c) {
			console.log(a);
			console.log(c);
		}else{
			console.log(c);
			console.log(a);
		};
	}else{
		console.log(c);
		if (a>b) {
			console.log(a);
			console.log(b);
		}else{
			console.log(b);
			console.log(a);
		}
	}	
}

document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var inputb=document.getElementById('b').value;
	var inputc=document.getElementById('c').value;
	var result = document.getElementById('result').innerHTML = 'View console F12';
	sort(inputa,inputb,inputc)
});

