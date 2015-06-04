function occurrences(text, word){
	var i,
		len,
		splitted=[],
		counter=0;
	splitted=text.split(/[\s,\\.,\\!,\\?]+/);
	for(i=0, len=splitted.length; i<len; i+=1){
		if (splitted[i].toLowerCase() === word.toLowerCase()) {
			counter+=1;
		};
	}
	console.log(splitted);
	return counter;
}

var text = "Lorem ipsum dolor sit amet, consectetur lorem adipisicing elit. Veniam velit itaque iste, Lorem doloribus, ab quae, explicabo similique numquam porro laborum ex impedit laboriosam ullam laudantium voluptatem minima molestias vel ut!",
	word;
document.getElementById("input").innerHTML = text;
document.getElementById("print").addEventListener("click", function(){
	word = document.getElementById("text").value.toLowerCase();
	document.getElementById("result").innerHTML = word+' - '+ occurrences(text, word)+ ' times';
});
