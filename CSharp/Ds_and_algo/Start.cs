using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class Start
    {
        public static void Main(string[] args)
        {
            int[] sortedArray = { 2, 5, 6, 8, 9, 12, 15, 26, 46, 66, 78, 89 };
            int[] unsortedArray = { 345, 51, 1, 99, 7, 3, 5, 7, 46, 34, 76, 22, 78, 34, 78, 98 };

            //Console.WriteLine("------------Binary Search---------");
            //BinarySearch BinarySearchObj = new BinarySearch(sortedArray, 46);
            //BinarySearchObj.Find();
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("------------Bubble Sort---------");
            //BubbleSort BubbleSortObj = new BubbleSort(unsortedArray);
            //BubbleSortObj.Sort();
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("------------Selection Sort---------");
            //SelectionSort SelectionSortObj = new SelectionSort(unsortedArray);
            //SelectionSortObj.Sort();
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("------------Insertion Sort---------");
            //InsertionSort InsertionSortObj = new InsertionSort(unsortedArray);
            //InsertionSortObj.Sort();
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("------------Merge Sort---------");
            //MergeSort MergeSortObj = new MergeSort();
            //int[] result = MergeSortObj.Sort(unsortedArray);
            //Console.WriteLine($"Sorted array:- {string.Join(", ", result)}");
            //Console.WriteLine("----------------------------------");

            Console.WriteLine("------------Quick Sort---------");
            QuickSort QuickSortObj = new QuickSort();
            int[] result = QuickSortObj.Sort(unsortedArray, 0, unsortedArray.Length - 1);
            Console.WriteLine($"Sorted array:- {string.Join(", ", result)}");
            Console.WriteLine("----------------------------------");
        }

    }
}
