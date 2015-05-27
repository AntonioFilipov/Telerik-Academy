function task(objects) {
	for (var object in objects) {
		var properties = [];
		
		for (var property in objects[object]) {
			properties.push(property);
		}

		properties.sort();
		
		console.log('Smallest property: ' + properties.shift());
		console.log('Largest property: ' + properties.pop());
		console.log(new Array(11).join('-'));
	}
}

document.getElementById('check').addEventListener('click', function() {
	document.getElementById('view').innerHTML = 'View console F12';
	task([document, window, navigator]);
});

