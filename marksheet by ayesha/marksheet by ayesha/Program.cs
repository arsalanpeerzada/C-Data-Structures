using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace marksheet_by_ayesha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t BOARD OF SECONDARY EDUCATION KARACHI");
            Console.WriteLine("\t MARK SHEET");

            string ENG = ("ENGLISH");
            Console.WriteLine(ENG);
            int A = 79;
            Console.WriteLine(A);
            Console.WriteLine("");
            string MATHS = ("MATHS");
            Console.WriteLine(MATHS);
            int B = 86;
            Console.WriteLine(B);
            Console.WriteLine("");
            string COMP = ("COMPUTER");
            Console.WriteLine(COMP);
            int C = 95;
            Console.WriteLine(C);
            Console.WriteLine("");
            string PST = ("PAKISTAN STUDIES");
            Console.WriteLine(PST);
            int D = 45;
            Console.WriteLine(D);
            Console.WriteLine("");
            string SINDHI = ("SINDHI");
            Console.WriteLine(SINDHI);
            int E = 56;
            Console.WriteLine(E);
            Console.WriteLine("");
            Console.WriteLine("TOTAL MARKS");
            Console.WriteLine(A + B + C + D + E);
            Console.WriteLine("");
            Console.WriteLine("PERCENTAGE");
            Console.WriteLine((A + B + C + D + E) / (5));
            Console.WriteLine("");
            Console.WriteLine("GRADE");
            Console.WriteLine("A");
            Console.ReadLine();
        }
    }
}
