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

            int[] a = new int[5];
            a[0] = 6;
            a[1] = 9;
            a[2] = 3;
            a[3] = 4;
            a[4] = 6;

            for (int i = 0; i <a.Length; i++)
            {
                if (a[i]==12)
                {
                    Console.WriteLine(6 +"  found at position  "+ (i+1));
                }
                else
                {
                    Console.WriteLine("Number not found !");
                    break;
                }
            }


        }
    }
}
