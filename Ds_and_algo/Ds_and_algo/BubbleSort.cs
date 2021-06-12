using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class BubbleSort
    {
        public int[] arr;
        public BubbleSort(int[] _arr)
        {
            arr = _arr;
        }

        public void Sort()
        {
            int arrLength = arr.Length - 1;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arrLength; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                arrLength--;
            }
            Console.WriteLine($"Sorted array:- {string.Join(", ", arr)}");

        }
    }
}
