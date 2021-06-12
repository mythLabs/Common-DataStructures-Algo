using System;
using System.Collections.Generic;
using System.Text;

namespace Ds_and_algo
{
    class Start
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 5, 6, 8, 9, 12, 15, 26, 46, 66, 78, 89 };
            BinarySearch obj = new BinarySearch(arr, 465 );
            obj.Find();
        }

    }
}
