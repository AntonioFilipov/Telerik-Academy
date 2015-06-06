Array.prototype.remove = function(item){
	var index;
	while(1){
		index=this.indexOf(item);
		if (index > -1) {
			this.splice(index, 1);	
	    	console.log(this);	
		}else{
			break;
		}
	}
};

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
document.getElementById("input").innerHTML=arr;
document.getElementById("check").addEventListener('click', function(){
	arr.remove(1);
	document.getElementById("result").innerHTML = arr + " See more result on the browser console";
});
