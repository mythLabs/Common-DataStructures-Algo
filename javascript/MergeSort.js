// Keep on splitting then keep on merging
function MergeSort(arr) {
  if (arr.length <= 1) return arr;
  let mid = Math.floor(arr.length / 2);
  let left = MergeSort(arr.slice(0, mid));
  let right = MergeSort(arr.slice(mid, arr.length));
  return merge(left, right);
}

function merge(arr1, arr2) {
  let temp = [];
  let i = 0;
  let j = 0;

  while (i < arr1.length && j < arr2.length) {
    if (arr1[i] < arr2[j]) {
      temp.push(arr1[i]);
      i++;
    } else {
      temp.push(arr2[j]);
      j++;
    }
  }

  while (i < arr1.length) {
    temp.push(arr1[i]);
    i++;
  }

  while (j < arr2.length) {
    temp.push(arr1[j]);
    j++;
  }

  return temp;
}

const sortedArr = MergeSort([
  345, 51, 1, 99, 7, 3, 5, 7, 46, 34, 76, 22, 78, 34, 78, 98,
]);

console.log(`Sorted array:- ${sortedArr}`);
