using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class QuickSort
    {
        public int[] Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = pivot(arr, left, right);

                Sort(arr, left, pivotIndex - 1);

                Sort(arr, pivotIndex + 1, right);
        }
            return arr;
        }

        private int pivot(int[] arr, int startIndex, int endIndex)
        {
            int pivotIndex = startIndex;
            int pivot = arr[startIndex];
            int temp;

            for(int i = startIndex; i <= endIndex; i++)
            {
                if(arr[i] < pivot)
                {
                    pivotIndex++;
                    temp = arr[i];
                    arr[i] = arr[pivotIndex];
                    arr[pivotIndex] = temp;
                }
            }

            temp = arr[pivotIndex];
            arr[pivotIndex] = arr[startIndex];
            arr[startIndex] = temp;

            return pivotIndex;
        }
    }
}
