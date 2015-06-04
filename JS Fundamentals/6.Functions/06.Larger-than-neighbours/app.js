function check(array, position){
	if (position >= array.length || position < 0) {
		return false;
	}else if (position > array.length-2 || position < 1) {
		return false;
	}else if (array[position] > array[position+1] && array[position] > array[position-1]) {
		console.log(array[position+1]);
		return true;
	}else{
		return false;
	}
}