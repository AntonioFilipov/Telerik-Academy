## Creating a form which change its color on radio button click ##

### Problem ###
You want every time the radio button is clicked, the background of the form which contains all of the radio buttons to change its color.

### Description ###
There is group of radio buttons with label attached to them. Each label has differnt color. When you click on radio button, the background color of the group of labels will change to color of the selected radio button.

### Solution ###
To include this functionality in your page, follow these steps:

1. In the body if your html page create a **form** tag with initial text.

		<form></form>
		

2. Add **id** to the form which you will use it to select it later.
 	
		<form id="radioButtonForm"></form>
	
3. Add **div** to the form to separate each radio button and labels attached to it from others

		<form id="radioButtonForm">
			<div>
			</div>
		</form>

4. In the div tag add **input** tag with type radio

		<input type="radio"/>

5. Add **id**, **name** and **onclick** event to the input

		<input id="1" type="radio" name="radio" onclick="check(this)">
	- **id** is used to select input later
	- **name** is used to select only one radio button(every input has same name)
	- **onclick** is called every time the button is clicked
	
6. In the div tag after previous input add **label** tag with some text 

		<label>RadioButton1</label>

7. Add **for**, **id** and **style** to the label

		<label for="1" id="rb1" style="color:orange;">RadioButton1</label>
	- **for** - it indicates which input is connected to the label (when you click on the label, the radio button connected to it is also clicked)
	- **id** is used to select label later
	- **style** is used to change color of the label

8. Repeat steps 3-7 to add other radio buttons. **Note** that the id of the **input** and **label** must be different from the others. **Example** of adding second radio button.

		<div>
			<input id="2" type="radio" name="radio" onclick="check(this)">
			<label for="2" id="rb2" style="color:blue;">RadioButton2</label>
		</div>

9. Now it is time to implement the function **check**. Add **script** tag at the end of the body of the html document.

		<body>
			....
			<script>
			</script>
		</body>

5.Add this code in the **script** tag.
		
		function check(myRadio){
			var id = myRadio.id;
			var labelColor = document.getElementById("rb"+id).style.color;

			document.getElementById('radioButtonForm').style.backgroundColor = labelColor;
		}

- first we create the function **check**

		function check(myRadio){
		}
	- **myRadio** - clicked button
	
- thеn implement functionality of the function **check**

	```
	var id = myRadio.id;
	```
	- get **id** of selected radio button

	```
	var labelColor = document.getElementById("rb"+id).style.color;
	```
	- get label color of the label with id equal to radio button id
	
	```
	document.getElementById('radioButtonForm').style.backgroundColor = labelColor;
	```
	- set color of the form with label color

### Code ###

		<!DOCTYPE html>
		<html>
		<head>
		</head>
		<style>
			#radioButtonForm{
				height: 100px;
				width:200px;
			}
		</style>
		<body>
		<form action="" id="radioButtonForm">
			<div>
				<input id="1" type="radio" name="radio" onclick="check(this)">
				<label for="1" id="rb1" style="color:orange;">RadioButton1</label>
			</div>
			
			<div>
				<input id="2" type="radio" name="radio" onclick="check(this)">
				<label for="2" id="rb2" style="color:blue;">RadioButton2</label>
			</div>
			
			<div>
				<input id="3" type="radio" name="radio" onclick="check(this)">
				<label for="3" id="rb3" style="color:red;">RadioButton3</label>
			</div>
	
			
			<div>
				<input id="4" type="radio" name="radio" onclick="check(this)">
				<label for="4" id="rb4" style="color:green;">RadioButton4</label>
			</div>
	
			<div>
				<input id="5" type="radio" name="radio" onclick="check(this)">
				<label for="5" id="rb5" style="color:black;">RadioButton5</label>
			</div>
			
		</form>
	
		<script>
			function check(myRadio){
				var id = myRadio.id;
				var labelColor = document.getElementById("rb"+id).style.color;
	
				document.getElementById('radioButtonForm').style.backgroundColor = labelColor;
			}
		</script>
</body>
</html>

### Demo ###
[Demo](http://dojo.telerik.com/EnADe)
### Using ###
- Open web page in some prefered browser
- You will see a five radio buttons with different colored text
- Every time you click the radio button, the background color of the form is changing

### Warnings ###
- every time you close or refresh the page, backgound of the form will be white
