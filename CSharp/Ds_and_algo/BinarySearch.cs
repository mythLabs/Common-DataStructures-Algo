using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class BinarySearch
    {
        public int start;
        public int end;
        public int middle;
        public int[] arr;
        public int elem;
        public BinarySearch(int[] arr, int elem)
        {
            this.arr = arr;
            this.elem = elem;
            start = 0;
            end = arr.Length - 1;
            middle = (start + end) / 2;
        }

        public void Find()
        {
            while (arr[middle] != elem && start <= end)
            {
                if (arr[middle] > elem)
                {
                    end = middle - 1;

                }
                else
                {
                    start = middle + 1;
                }
                middle = (start + end) / 2;
            }

            if (arr[middle] == elem)
            {
                Console.WriteLine($"Found at index:- {middle}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }
    }
}
