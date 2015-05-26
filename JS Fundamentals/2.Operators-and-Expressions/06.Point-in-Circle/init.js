function p(x,y){
	var parsedx = x * 1;
	var parsedy = y * 1;
    return Math.sqrt(parsedx*parsedx+parsedy*parsedy) <= 5;
}

document.getElementById('check').addEventListener('click', function(){
    var inputx = document.getElementById('x').value;
    var inputy = document.getElementById('y').value;
    document.getElementById('result').innerHTML = p(inputx, inputy);
});