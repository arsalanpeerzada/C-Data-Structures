using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace math_library
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of sine is {0}",Math.Sin(numb));
            Console.WriteLine("Value of cosine is {0}", Math.Cos(numb));
            Console.WriteLine("Value of tangent is {0}", Math.Tan(numb));
            Console.WriteLine("Value of power is {0}", Math.Pow(numb,2));
            Console.WriteLine("Value of Square root is {0}", Math.Sqrt(numb*numb));
            Console.WriteLine(Math.BigMul(7,numb));
        }
    }
}
