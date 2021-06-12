function SelectionSort(arr) {
  let temp;
  let minimum;
  for (let i = 0; i < arr.length; i++) {
    minimum = i;
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[minimum] > arr[j]) {
        minimum = j;
      }
    }
    if (i != minimum) {
      temp = arr[i];
      arr[i] = arr[minimum];
      arr[minimum] = temp;
    }
  }

  console.log(`Sorted array:- ${arr}`);
}

SelectionSort([345, 51, 1, 99, 7, 3, 5, 7, 46, 34, 76, 22, 78, 34, 78, 98]);
