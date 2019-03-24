using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\t Enter Numbers");
            int[] data = new int[10];

            data[0] = 10;
            data[1] = 20;
            data[2] = 30;
            data[3] = 40;
            data[4] = 50;
            data[5] = 60;
            data[6] = 70;
            data[7] = 80;
            data[8] = 90;
            data[9] = 100;


            int x = 1;
            int y = 10;
            int mid = (x + y) / 2;
            Console.WriteLine("\t Enter Target ");
            int value=Convert.ToInt32(Console.ReadLine());
            int location=0;
            for (int i = 0; x<=y && value!=data[mid]  ; i++)
            {
                if (value>data[mid])
                {
                    x = mid + 1;
                }
                else
                {
                    y = mid - 1;
                }
                mid = (x + y) / 2;
               
            }
            if (value!=data[mid])
            {
                Console.WriteLine("Location Not Found");
            }
            else
            {
                Console.WriteLine("Number {0} Found at Location {1}",data[mid],location);
            }


        }
    }
}
