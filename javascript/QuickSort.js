//keep on pivotting left and right to reduce let and right value
function QuickSort(arr, left= 0, right = arr.length - 1) {
    if (left < right) {
    let pivotIndex = pivot(arr,left, right);

        //left
    QuickSort(arr, left, pivotIndex - 1)
     
        //right
    QuickSort(arr,pivotIndex + 1, right)
    }

    return arr;
}

// all small on one side (swap big & small elements) and replace last small with first making it the pivot
function pivot(arr, startIndex, endIndex)  {
   let pivot = arr[startIndex];
   let pivotIndex = startIndex;
   let temp;

   for(i = startIndex; i <= endIndex; i++) {
       if(pivot > arr[i]) {
        pivotIndex++;
        temp = arr[i]
        arr[i] = arr[pivotIndex]
        arr[pivotIndex] = temp;
       }
   }

   temp = arr[pivotIndex];
   arr[pivotIndex] = arr[startIndex]
   arr[startIndex] = temp;

   return pivotIndex

}

//pivot([5,2,1,8,4,7,6,3], 0, )

QuickSort([345, 51, 1, 99, 7, 3, 5, 7, 46, 34, 76, 22, 78, 34, 78, 98]);
  