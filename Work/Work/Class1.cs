using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work
{
    class Class1
    {
       /* protected internal*/ Double length;
       /* protected internal*/ Double width;
        public Double area;
        public Double perimeter;
        public Double Calculate_area()
        {
            Console.WriteLine("\t\tSqaure or rectangle");
            Console.WriteLine("\nEnter length:");
             length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter width:");
             width = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            Console.WriteLine("\nThe area is : {0}", area);

            if (length == width)
            {
                Console.WriteLine("\nYes, its a square.");
            }
            else
            {
                Console.WriteLine("\nNo, its not a square.");
            }
            return area;

        }

        public void Calculate_parameter()
        {
            double perimeter = ((2*length) * (2*width));
            Console.WriteLine("\nThe parameter is : {0}", perimeter);
        }
    }
    }
