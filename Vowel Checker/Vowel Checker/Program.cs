using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vowel_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            string input = obj.user_name();
            Console.WriteLine("\n\nYour entered name is {0}", input);
            int num_of_vowel = obj.vowel();
            Console.WriteLine("\nThe number of vowel present in your name is {0}", num_of_vowel);
            Console.ReadKey();     

        }
    }
}
