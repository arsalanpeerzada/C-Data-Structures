using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace traversing_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i; 
            }

            int length = array.Length;

            for (int i = 1 ; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
