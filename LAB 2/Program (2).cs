using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int var = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number to Swap: ");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int swap;

            Console.WriteLine("Press any Key to Swap");
            Console.ReadKey();
            swap = var;
            var = var2;
            var2 = swap;

            Console.WriteLine("First Number {0} Second Number {1}",var,var2);
        }
    }
}
