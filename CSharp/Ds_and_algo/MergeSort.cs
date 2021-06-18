using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            if (arr.Length <= 1) return arr;
            int mid = arr.Length / 2;
            int[] left = Sort(arr.Slice(0, mid));
            int[] right = Sort(arr.Slice(mid, arr.Length));

            return merge(left, right);

        }

        private int[] merge(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            int i = 0;
            int j = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    result.Add(arr1[i]);
                    i++;
                }
                else
                {
                    result.Add(arr2[j]);
                    j++;
                }
            }

            while (i < arr1.Length)
            {
                result.Add(arr1[i]);
                i++;
            }

            while (j < arr2.Length)
            {
                result.Add(arr2[j]);
                j++;
            }

            return result.ToArray();
        }


    }

    public static class helper
    {
        public static T[] Slice<T>(this T[] arr, int indexFrom, int indexTo)
        {
            if (indexFrom > indexTo)
            {
                throw new ArgumentOutOfRangeException("indexFrom is bigger than indexTo!");
            }

            int length = indexTo - indexFrom;
            T[] result = new T[length];

            //Copies a range of elements from an Array starting at the specified source index and pastes them to another Array starting at the specified destination index. The length and the indexes are specified as 64 - bit integers.
            Array.Copy(arr, indexFrom, result, 0, length);

            return result;
        }
    }


}
