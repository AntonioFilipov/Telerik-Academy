function check(a,b,c,d,e){
	var a = a*1;
	var b = b*1;
	var c = c*1;
	var d = d*1;
	var e = e*1;

	if (a>b) {
		if (a>c) {
			if (a>d) {
				if (a>e) {
					return a;
				}
			}
		}
	}

	if (b>a) {
		if (b>c) {
			if (b>d) {
				if (b>e) {
					return b;
				}
			}
		}
	}

	if (c>a) {
		if (c>b) {
			if (c>d) {
				if (c>e) {
					return c;
				}
			}
		}
	}

	if (d>a) {
		if (d>b) {
			if (d>c) {
				if (d>e) {
					return d;
				}
			}
		}
	}
	return e;	
}

document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var inputb=document.getElementById('b').value;
	var inputc=document.getElementById('c').value;
	var inputd=document.getElementById('d').value;
	var inpute=document.getElementById('e').value;
	var result = document.getElementById('result').innerHTML = check(inputa,inputb,inputc,inputd,inpute);

});

