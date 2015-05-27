function check(a,b,c){
	var a = +a;
	var b = +b;
	var c = +c;
	if (a < 0 && b >0 && c >0) {
		return '-';
	}else if(a<0 && b>0 && c<0){
		return '+';
	}else if(a<0 && b<0 && c>0){
		return '+';;
	}else if(a<0 && b<0 && c<0){
		return '-';
	}else if(a>0 && b>0 && c>0){
		return '+';
	}else if(a>0 && b>0 && c<0){
		return '-';
	}else if(a>0 && b<0 && c>0){
		return '-';
	}else if(a>0 && b<0 && c<0){
		return '+';
	}else return 0;
}

document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var inputb=document.getElementById('b').value;
	var inputc=document.getElementById('c').value;
	var result = document.getElementById('result').innerHTML = check(inputa,inputb,inputc);
});

