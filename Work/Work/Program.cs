using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj_of_rec = new Class1();
            Double result = obj_of_rec.Calculate_area();
            obj_of_rec.Calculate_parameter();
            Console.ReadKey();
        }
    }
}
