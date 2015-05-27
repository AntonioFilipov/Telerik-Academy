function check(a){
	var a = a*1;
	var strNumber;
	switch(a){
		case 0: strNumber='Zero';break;
		case 1: strNumber='One';break;
		case 2: strNumber='Two';break;
		case 3: strNumber='Three';break;
		case 4: strNumber='Four';break;
		case 5: strNumber='Five';break;
		case 6: strNumber='Six';break;
		case 7: strNumber='Seven';break;
		case 8: strNumber='Eight';break;
		case 9: strNumber='Nine';break;
		default: strNumber="not a digit";break
	}
	return strNumber;
}

document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var result = document.getElementById('result').innerHTML = check(inputa);
});

