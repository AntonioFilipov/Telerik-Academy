if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var pattern,
            result = this,
            prop;
        for (prop in options) {
            pattern = new RegExp('\#\{' + prop + '\}');
            result = result.replace(pattern, options[prop]);
        }
        return result;
    }

}
var options01 = { name: 'John' };
var options02 = { name: 'John', age: 13 };
var string01 = 'Hello, there! Are you #{name}?';
var string02 = 'My name is #{name} and I am #{age}-years-old';

document.getElementById("input").innerHTML=string01+'\n'+string02;
document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML=string01.format(options01)+'\n'+string02.format(options02);
	console.log(string01.format(options01));
    console.log(string02.format(options02));
});