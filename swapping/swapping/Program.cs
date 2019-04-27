using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 4, b = 6;
            a ^= b ;
            b ^= a;
            a ^= b;
            
            Console.WriteLine("Value of A : {0},Value of B : {1}",a,b);
        }
    }
}
