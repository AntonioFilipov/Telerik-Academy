function check(number){
	var parsedNumber=number|0;
    if(parsedNumber%5===0 && parsedNumber%7===0){
        return true;
    }
    else{
        return false;
    }
}

document.getElementById('check').addEventListener('click', function(){
    var inputNumber = document.getElementById('number').value;
    document.getElementById('result').innerHTML = check(inputNumber);
});