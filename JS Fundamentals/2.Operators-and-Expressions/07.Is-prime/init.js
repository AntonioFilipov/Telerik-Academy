function isPrime(num){
	var number = num | 0;
    if(number===1){
        return false;
    };

    if (number===2) {
    	return true;
    };

    if (number < 0) {
    	return false;
    };

    if (number > 100) {
    	return document.getElementById('result').innerHTML = 'wrong input';

    };

    for(var i=2; i<=Math.sqrt(number);i+=1){
        if((number%i)===0){
            return false;
        }
    }
    return true;
}

document.getElementById('check').addEventListener('click', function(){
    var inputNumber = document.getElementById('number').value;
    document.getElementById('result').innerHTML = isPrime(inputNumber);
});

