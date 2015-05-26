function oddOrEven(number){
    var parsedNumber = number | 0;
    if(parsedNumber%2===0){
        return 'even';
    }
    else{
        return 'odd';
    }
}

document.getElementById('check').addEventListener('click', function(){
    var inputNumber = document.getElementById('number').value;
    document.getElementById('result').innerHTML = oddOrEven(inputNumber);
});