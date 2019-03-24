using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an application that inputs from the user the radius of a circle and prints the circle’s diameter, 
            // circumference and area. 
            // Use the following formulas (r is the radius): diameter = 2r, circumference = 2 ðr, area = ðr2
            int rad, dia;
            double cir, area;
            double pai = 3.14;
            Console.WriteLine("Enter any num :");
            rad = Int32.Parse(Console.ReadLine());
            dia = 2 * rad;
            cir = 2 * pai * rad;
            area = pai * rad * 2;
            Console.WriteLine("Daimeter: {0}", dia);
            Console.WriteLine("Circumference : {0}", cir);
            Console.WriteLine("Area : {0}", area);
            Console.ReadKey();
        }
    }
}