function generateList(people, template) {
    var resultHTML = '<ul>',
        i;
    for (i = 0; i < people.length; i+=1) {
        resultHTML += '<li>';
        resultHTML += template.replace('-{name}-', people[i]['name']).replace('-{age}-', people[i]['age']);
        resultHTML += '</li>';
    }
    return resultHTML + '</ul>';
}

var people = [{ name: 'Peter', age: 14 },
{ name: 'Ivan', age: 18 },
{ name: 'Asen', age: 29 }];

var template = '<strong>-{name}-</strong> <span>-{age}-</span>';

document.getElementById("check").addEventListener("click", function(){
    document.getElementById("input").innerHTML = "See console!";
	document.getElementById("result").innerHTML= generateList(people, template);
    console.log(people);
});