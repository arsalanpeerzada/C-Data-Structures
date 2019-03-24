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


            //int[] array = new int[10] { 9, 8, 5, 6, 3,100,45,23,5,77 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length-1; j++)
            //    {
                    //if (array[j]>array[j+1])//change '<' or '>' sign for ascending and descending order
            //        {
            //            int temp = array[j];
            //            array[j] = array[j+1 ];
            //            array[j + 1] = temp;
            //        }
            //    }


                
            //}
            //Console.WriteLine("...Sorted array...");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]+"\n");
            //}
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum =+ array[i];
              
            //}
            //int average = sum / array.Length;
            //Console.WriteLine("Average value is:"+average);


            List<int> mylist = new List<int>();
            List<int> yourlist = new List<int>();
            //mylist.Add(5);
            //mylist.Add(6);
            //for (int i = 0; i < mylist.Count; i++)
            //{


            //    Console.WriteLine(mylist[i]);
            //}
           //foreach(int prime in mylist)
           // {
           //     Console.WriteLine(prime);
           // }


            mylist.Add(4);
            mylist.Add(10);
            mylist.Add(7);
            mylist.Add(55);
            mylist.Add(3);

            yourlist.Add(10);
            yourlist.Add(23);
            yourlist.Add(44);

            mylist.AddRange(yourlist);
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist[i] + "\n");
            }

         

           

        }
    }
}
