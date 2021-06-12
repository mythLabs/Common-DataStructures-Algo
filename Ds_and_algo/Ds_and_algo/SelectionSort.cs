using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class SelectionSort
    {
        public int[] arr;
        public SelectionSort(int[] _arr)
        {
            arr = _arr;
        }

        public void Sort()
        {
            int minimum;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                minimum = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minimum] > arr[j])
                    {
                        minimum = j;
                    }
                }

                if (i != minimum)
                {
                    temp = arr[i];
                    arr[i] = arr[minimum];
                    arr[minimum] = temp;
                }

            }
            Console.WriteLine($"Sorted array:- {string.Join(", ", arr)}");

        }
    }
}
