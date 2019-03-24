using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insertion_into_unsorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 5;
            int[] a=new int [X];
            a[0] = 4;
            a[1] = 5;
            a[2] = 6;
            a[3] = 7;
            a[4] = 8;
            int item = Convert.ToInt32(Console.ReadLine());
            int pos=Convert.ToInt32(Console.ReadLine());
            for (int i = X; i >= pos; i++)
            {
                a[i + 1] = a[i];
                X = X - 1;
                a[pos] = item;
            }

            for (int i = 0; i < X; i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }
}
