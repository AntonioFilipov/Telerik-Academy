function lastNumber(number){
	var lastDigit = number%10;
	switch(lastDigit){
		case 1: return 'One'; 
		case 2: return 'Two';
		case 3: return 'Three';
		case 4: return 'Four';
		case 5: return 'Five';
		case 6: return 'Six';
		case 7: return 'Seven';
		case 8: return 'Eight';
		case 9: return 'Nine';
		case 0: return 'Zero';
	}
}

var number;
document.getElementById("print").addEventListener("click", function(){
	number = document.getElementById("input").value;
	document.getElementById("result").innerHTML = lastNumber(+number);
});
