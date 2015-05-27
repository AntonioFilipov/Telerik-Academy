function check(a,b,c){
	var a = a*1;
	var b = b*1;
	var c = c*1;
	var descr = b*b-4*a*c;
	var x1, x2;
	if (descr<0) {
		return "no real roots";
	}else{
		console.log(2/4);
		x1=(-b+Math.sqrt(descr))/(2*a);
		x2=(-b-Math.sqrt(descr))/(2*a);
	}
	return 'x1='+x1+'; '+'x2='+x2;
}

document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var inputb=document.getElementById('b').value;
	var inputc=document.getElementById('c').value;
	var result = document.getElementById('result').innerHTML = check(inputa,inputb,inputc);

});

