using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[6] { 22, 33, 3, 21, 99, 8 };
            int ptr;
            for (int i = 1; i < 6; i++)
            {
                ptr = i - 1;
                int temp = array[i];

                while (temp<array[ptr] && ptr>0)
                {
                    array[ptr + 1] = array[ptr];
                    ptr = ptr - 1;
                }

                array[ptr + 1] = temp;
                
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+"\n");
            }

        }
    }
}
