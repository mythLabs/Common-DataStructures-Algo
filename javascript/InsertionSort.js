// Keep on generating sorted array on one portion of existing array
function InsertionSort(arr) {
  sortedLength = 0;
  let temp;
  for (let i = 1; i < arr.length; i++) {
    for (let j = 0; j < i; j++) {
      if (arr[j] > arr[i]) {
        temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
      }
    }
  }

  console.log(`Sorted array:- ${arr}`);
}

InsertionSort([345, 51, 1, 99, 7, 3, 5, 7, 46, 34, 76, 22, 78, 34, 78, 98]);
