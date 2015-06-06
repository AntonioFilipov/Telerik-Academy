function youngestPerson(array){
	var i,
		len,
		min=Number.MAX_VALUE,
		fname,
		lname;
	for(i=0, len=array.length;i<len;i++){
		if (array[i].age < min) {
			min=array[i].age;
			fname=array[i].firstname;
			lname=array[i].lastname;
		};
	}
	return fname+" "+lname+" "+min+" years old.";
}

var people = [
 	{ firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  	{ firstname : 'Bay', lastname: 'Ivan', age: 13},
	{ firstname : 'Tonko', lastname: 'Ivanov', age: 19}
];
document.getElementById("check").addEventListener('click', function(){
	document.getElementById("result").innerHTML = youngestPerson(people);
	});