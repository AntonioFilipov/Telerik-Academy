function parse(string) {
	resultString = '';
	  for (var i = 0; i < string.length; i++) {
	      if (string[i] !== '<') {
	          resultString += string[i];
	      }
	      else {
	          i++;
	          if (string[i] === 'm') {
	              i += 8;
	              while (string[i] !== '<') {
	                  if (Math.round(Math.random())) {
	                      resultString += string[i].toUpperCase();
	                  }
	                  else {
	                      resultString += string[i].toLowerCase();
	                  }
	                  i++;
	              }
	              i += 10;
	          }
	          if (string[i] === 'u') {
	              i += 7;
	              while (string[i] !== '<') {
	                  resultString += string[i].toUpperCase();
	                  i++;
	              }
	              i += 9;
	          }
	          if (string[i] === 'l') {
	              i += 8;
	              while (string[i] !== '<') {
	                  resultString += string[i].toLowerCase();
	                  i++;
	              }
	              i += 10;
	          }
	      }
	  }
	  return resultString;
}

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
document.getElementById("input").innerHTML=text;

document.getElementById("check").addEventListener("click", function(){
	document.getElementById("result").innerHTML= parse(text);
});