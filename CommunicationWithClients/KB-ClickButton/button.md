## Creating a button which visualize number of clicks ##

### Problem ###
Missing a button which counts number of clicks

### Description ###
If you want to know how many times something on the web page e.g button, navigation, category is clicked, you can use this example.

### Solution ###
To include this button in your page, follow these steps:

1. In the body if your html page create a button tag with initial text.

	```
	<button>o.</button>
	```

2. Add **id** to the button which you will use it to select it later.

 	```
	<button id="increasingButton">o.</button>
	```

3. Add **onclick** event which will call a function that changes the text in button on every click.

 	```
	<button id="increasingButton" onclick="clicker()">o.</button>
	```

4. Now it is time to implement the function **clicker**. Add **script** tag at the end of the body of the html document.

		<body>
			<button id="increasingButton" onclick="clicker()">o.</button>
			....
			<script>
			</script>
		</body>

5.Add this code in the **script** tag.

		
		var counter= 0;
		function clicker(){
			document.getElementById("increasingButton").innerHTML = counter;
			counter+=1;
		}
		

- first we create variable **counter** which holds number of clicks

	```
	var counter= 0;
	```
	- initalize variable with 0

- second we create the function **clicker**

		function clicker(){
		}

	
- thеn implement functionality of the function **clicker**

	```
	document.getElementById("increasingButton").innerHTML  = counter;
	```
	- select the button with *increasingButton* **id** and change its text to variable **counter**

	```
	counter+=1;
	```
	- increse value of the variable with 1, every time the function is call.

### Code ###

		<!DOCTYPE html>
		<html>
		<head>
		</head>
		<body>
			<button id="increasingButton" onclick='clicker()'>o.</button>
		</body>
			<script>
				var counter= 0;
				function clicker(){
					document.getElementById("increasingButton").innerHTML = counter;
					counter+=1;
				}
			</script>
		</html>

### Demo ###
[Demo](http://dojo.telerik.com/eWOYU)
### Using ###
- Open web page in some prefered browser
- You will see a button with text <q>o.</q>
- Every time you click the button, the number in the button will increase by 1

### Warnings ###
- every time you close or refresh the page, number of clicks will be zero
- if you click the button more than [max number value in javascript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Number/MAX_SAFE_INTEGER), there will be problems with counting number of clicks (the solution is to close or refresh the web page).
