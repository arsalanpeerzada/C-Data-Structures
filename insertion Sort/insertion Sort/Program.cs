using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 2, 1, 4, 3 };

            Sort obj = new Sort();
            obj.InsertionSort(arr);
        }
    }
}
