using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {


            //int a = 5;
            //int b = 10;
            //int temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine(b);


            int[] array = new int[5] { 9, 8, 5, 6, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1 ];
                        array[j + 1] = temp;
                    }
                }


                
            }
            Console.WriteLine("...Sorted array...");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+"\n");
            }



        }
    }
}
