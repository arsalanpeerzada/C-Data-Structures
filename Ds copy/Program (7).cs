using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest_element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 1;
            int loc = 1;
            int[] data = new int[5];
            for (int i = 0; i <data.Length; i++)
            {
                Console.WriteLine("Enter a number");
                data[i] =Convert.ToInt32( Console.ReadLine());
            }

            int max = data[0];
           while (k <= 4)
            {
                if (max<data[k])
                {
                    loc = k;
                    max = data[k];
                }

                k = k + 1;
               
            }

           Console.WriteLine("Location is: " + (loc + 1) + " and max number is: " + max);
        }
    }
}
