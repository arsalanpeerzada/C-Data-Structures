using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Physics A1, A2;
            A1 = new Physics();
            string a = A1.Calculation(0, 0);
           Console.WriteLine(a);
           Console.WriteLine();
           A2 = new Physics();
          string b =  A2.Calculation(0, 0, 0);
          Console.WriteLine(b);
           

        }
    }
}
