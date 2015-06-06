function Point(x,y){
	this.x=x;
	this.y=y;
}

function getLength(pointA, pointB){
	var side1=pointA.x-pointB.x;
	var side2=pointA.y-pointB.y;
	return Math.sqrt(side1*side1 + side2*side2);
}

var pointA = new Point(1,4);
var pointB = new Point(5,1);
var pointB = new Point(4,1);



document.getElementById("check").addEventListener('click', function(){
	document.getElementById("result").innerHTML = 'Line length between ('+pointA.x+', '+pointB.x+') and ('+pointA.y+', '+pointB.y+'):'+getLength(pointA, pointB);
});
console.log(pointA);
console.log(pointB);
console.log(getLength(pointA,pointB));