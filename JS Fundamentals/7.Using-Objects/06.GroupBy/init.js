function groupBy(array,group){
	var i,
		len,
		hash={},
		value=[];
	for(i=0, len=array.length;i<len;i++){
		if (array[i].hasOwnProperty(group)) {
			value.push(array[i]);			
		};
	}
	hash[group] = value;
	console.log(hash);
	return hash;
}

var people = [
 	{ firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  	{ lastname: 'Ivan', age: 13},
	{ firstname : 'Tonko', lastname: 'Ivanov', age: 19}
];
document.getElementById("check").addEventListener('click', function(){
	groupBy(people, "firstname");
	document.getElementById("result").innerHTML = "Open console to see result!";
	});