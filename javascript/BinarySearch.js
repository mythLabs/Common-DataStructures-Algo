function binarySearch(arr, elem) {
  let start = 0;
  let end = arr.length - 1;
  let middle = Math.floor((start + end) / 2);

  while (arr[middle] !== elem && start <= end) {
    if (arr[middle] < elem) {
      start = middle + 1;
    } else {
      end = middle - 1;
    }

    middle = Math.floor((start + end) / 2);
  }

  if (arr[middle] == elem) {
    console.log(`Element at index:- ${middle}`);
  } else {
    console.log("Not Found");
  }
}

binarySearch([2, 5, 6, 8, 9, 12, 15, 26, 46, 66, 78, 89], 126);
