using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insertion_Sort
{
    class Sort
    {
        public void InsertionSort(int[] intArray)
        {
            Console.WriteLine("==========Integer Array Input===============");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            int temp, j;
            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] > temp)
                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }

                intArray[j + 1] = temp;
            }

            Console.WriteLine("==========Integer Array OutPut===============");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
