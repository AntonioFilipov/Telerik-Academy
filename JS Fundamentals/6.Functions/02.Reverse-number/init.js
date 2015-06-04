function splitNumber(number){
   var list=[];
   list=number.split('.');
   return list;
}

function reverseNumber(number){
	var i,
		tempReverse,
      reverse='',
      list=splitNumber(number),
      len,
      currentNumber=0;
      for(i=0, len=list.length; i<len; i+=1){
         currentNumber=+list[i];
         tempReverse=0;
         while (currentNumber !== 0){
            tempReverse = tempReverse * 10;
            tempReverse = tempReverse + currentNumber%10;
            currentNumber=(currentNumber/10)|0;
         }
         reverse+=tempReverse+'.';
      }
   	

   return +reverse.substring(0, reverse.length-1).split(".").reverse().join(".");
}

var number;
document.getElementById("print").addEventListener("click", function(){
	number = document.getElementById("input").value;
	document.getElementById("result").innerHTML = reverseNumber(number);
});
