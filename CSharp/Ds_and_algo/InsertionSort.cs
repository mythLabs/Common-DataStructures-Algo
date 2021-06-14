using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class InsertionSort
    {
        public int[] arr;
        public InsertionSort(int[] _arr)
        {
            arr = _arr;
        }

        public void Sort()
        {
            int temp;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Sorted array:- {string.Join(", ", arr)}");

        }
    }
}
