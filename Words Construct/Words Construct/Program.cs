using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Words_Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Choose Your Word
an 
ed
ig
at
et
in
op
ot
un");
            string lastWord = Console.ReadLine();

            Console.WriteLine("You choosed your word Successfully..........!");

            Console.Clear();

            Console.WriteLine(@"Choose Word from Word list 
a
b
c
d
e");
            string fWord = Console.ReadLine();

            string word = fWord + lastWord;

            //if (word)
            //{
                
            //}
        }
    }
}
