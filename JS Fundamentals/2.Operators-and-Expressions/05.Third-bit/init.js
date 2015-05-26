function check(number){
	var parsedNumber = number|0;
	console.log(parsedNumber>>3&1===1);
    if(parsedNumber>>3&1===1){
        return 1;
    }
    else{
        return 0;
    }
}

document.getElementById('check').addEventListener('click', function(){
    var inputNumber = document.getElementById('number').value;
    document.getElementById('result').innerHTML = check(inputNumber);
});