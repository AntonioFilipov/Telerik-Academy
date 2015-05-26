function check(x,y){
	var x=x*1;
	var y=y*1;
	var inCircle = Math.sqrt((x-1)*(x-1)+(y-1)*(y-1)) <= 3;
	var inRectangle = x>=-1 && x<=5 && y<=1 && y>=-1;
	if (inCircle && !inRectangle) {
		return 'yes';
	}
	else{
		return 'no';
	}
}

document.getElementById('check').addEventListener('click', function(){
    var x = document.getElementById('x').value;
    var y = document.getElementById('y').value;
	document.getElementById('result').innerHTML = check(x,y);
});
