function check(number){
	var parsedNumber = number | 0;
    return ((parsedNumber/100|0)%10===7);
}

document.getElementById('check').addEventListener('click', function(){
    var inputNumber = document.getElementById('number').value;
    document.getElementById('result').innerHTML = check(inputNumber);
});