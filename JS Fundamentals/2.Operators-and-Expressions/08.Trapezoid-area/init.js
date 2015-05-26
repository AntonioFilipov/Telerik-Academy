function area(a,b,h){
	var a = a*1;
	var b = b*1;
	var c = c*1;
	return (a+b)*h/2;
}
document.getElementById('check').addEventListener('click', function(){
    var a = document.getElementById('a').value;
    var b = document.getElementById('b').value;
	var c = document.getElementById('c').value;
    document.getElementById('result').innerHTML = area(a,b,c);
});
