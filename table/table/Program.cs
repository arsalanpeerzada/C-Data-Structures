using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("        Enter the Desired Number:  ");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("       "+num+" X "+i+" = "+(num*i));
            }
            Console.ReadLine();
        }
    }
}
