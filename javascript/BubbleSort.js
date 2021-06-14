// Continuous comparison with neighbours will bubble sorted elements
function BubbleSort(arr) {
  let arrLength = arr.length - 1;
  let temp;
  for (let i = 0; i < arr.length; i++) {
    for (let j = 0; j < arrLength; j++) {
      if (arr[j] > arr[j + 1]) {
        temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
    }
    arrLength--;
  }

  console.log(`Sorted array:- ${arr}`);
}

BubbleSort([345, 51, 1, 99, 7, 3, 5, 7, 46, 34, 76, 22, 78, 34, 78, 98]);
