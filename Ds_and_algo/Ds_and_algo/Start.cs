using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class Start
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------Binary Search---------");
            int[] Sarr = { 2, 5, 6, 8, 9, 12, 15, 26, 46, 66, 78, 89 };
            BinarySearch BinarySearchObj = new BinarySearch(Sarr, 465 );
            BinarySearchObj.Find();
            Console.WriteLine("----------------------------------");

            Console.WriteLine("------------Bubble Sort---------");
            int[] USarr = { 345, 51, 1, 99, 7, 3, 5, 7, 46, 34, 76, 22, 78, 34, 78, 98 };
            BubbleSort BubbleSortObj = new BubbleSort(USarr);
            BubbleSortObj.Sort();
            Console.WriteLine("----------------------------------");
        }

    }
}
