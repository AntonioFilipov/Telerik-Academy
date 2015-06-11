function extract(s) {
	var result = s.split(' ').filter(function(item){
		if (item.indexOf('@') > 0) {
			return item;
		}
	});
	return result;
}

var text = "Lorem ipsum dolor sit amet, consectetur adipisicing eli@abv.bg abo maiores earum autem quis atque in@gmail.com tempora possimus eos, illo sapiente.";
document.getElementById("input").innerHTML= text;
document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= '['+extract(text)+']';
	console.log(extract(text));
});