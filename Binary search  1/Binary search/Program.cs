using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] array = new int[5];
            //array[0] = 5;
            //array[1] = 50;
            //int x = array.Length;
            //Console.WriteLine(x);


            int[] array = new int[10] { 4, 5, 9, 10, 20, 24, 25, 36, 46, 50 };

            int x = 0;
            int y = array.Length;

            Console.Write("Enter value to search: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int mid = (x + y) / 2;
            while (x<=y && value!=array[mid])
            {
                if (value>array[mid])
                {
                    x = mid + 1;
                }
               
                else
                {
                    y = mid - 1;
                }

                mid = (x + y) / 2;
            }

            if (array[mid]!=value)
            {
                Console.WriteLine("Not found !");
                
            }

            else
            {
                Console.WriteLine("Value found "+value+" at location: "+(mid+1));
            }
        }
    }
}
