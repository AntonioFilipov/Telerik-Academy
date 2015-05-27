function oneDigit(a){
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
	}

	return strNumber;
}

function specialDigit(a){
	var a = a*1;
	var strNumber;
	switch(a){
		case 0: strNumber='Ten';break;
		case 1: strNumber='Eleven';break;
		case 2: strNumber='Twelve';break;
		case 3: strNumber='Thirteen';break;
		case 4: strNumber='Frourteen';break;
		case 5: strNumber='Fifteen';break;
		case 6: strNumber='Sixteen';break;
		case 7: strNumber='Seventeen';break;
		case 8: strNumber='Eighteen';break;
		case 9: strNumber='Nineteen';break;
	}

	return strNumber;
}

function twoDigit(a){
	var a = a*1;
	var strNumber;
	switch(a){
		case 2: strNumber='Twenty';break;
		case 3: strNumber='Thirty';break;
		case 4: strNumber='Fourty';break;
		case 5: strNumber='Fifty';break;
		case 6: strNumber='Sixty';break;
		case 7: strNumber='Seventy';break;
		case 8: strNumber='Eighty';break;
		case 9: strNumber='Ninety';break;
		default: strNumber='';break;
	}
	return strNumber;
}

function number(a){
	var a = a*1;
	var strNumber;
	var firstDigit=parseInt(a%10);

	var secondDigit=parseInt(a/10%10);

	var thirdDigit=parseInt(a/100);
	if (a >= 100 && a<=999) {
		if (secondDigit===0 && firstDigit===0){
			strNumber=oneDigit(thirdDigit)+' hundred';
		}else if (secondDigit===1) {
			strNumber=oneDigit(thirdDigit)+' hundred and '+specialDigit(firstDigit);
		}else if (secondDigit===0) {
			strNumber=oneDigit(thirdDigit)+' hundred and '+oneDigit(firstDigit);
		}else if (firstDigit===0) {
			strNumber=oneDigit(thirdDigit)+' hundred and '+twoDigit(secondDigit);
		}else{
			strNumber=oneDigit(thirdDigit)+' hundred and '+twoDigit(secondDigit)+oneDigit(firstDigit);
		}
	}else if(a >= 20 && a<=99){
		if (firstDigit===0) {
			strNumber=twoDigit(secondDigit);
		}else{
			strNumber=twoDigit(secondDigit)+oneDigit(firstDigit);
		}
		
	}else if(a>=0 && a<=19){
		if (secondDigit===1) {
			strNumber=specialDigit(firstDigit);
		}else{
			strNumber=oneDigit(firstDigit);
		}
	}
	return strNumber;
}



document.getElementById('check').addEventListener('click',function() {
		/* Act on the event */
	var inputa=document.getElementById('a').value;
	var result = document.getElementById('result').innerHTML = number(inputa);
});

