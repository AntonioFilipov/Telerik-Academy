function area(width, height){
	var parsedWidth = width | 0;
	var parsedHeight = height | 0;
    var area = width*height;
    return area;
}

document.getElementById('check').addEventListener('click', function(){
    var inputWidth = document.getElementById('width').value;
    var inputHeight = document.getElementById('height').value;
    document.getElementById('result').innerHTML = area(inputWidth, inputHeight);
});