using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace reading_and_writing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "abcd.txt";

            string [] data_A=new string [10];

            for (int i = 0; i < data_A.Length; i++)
            {
                data_A[i] = Console.ReadLine();
            }

            File.WriteAllLines(path, data_A);

            Console.Clear();

            Console.ReadLine();
            Console.WriteLine(File.ReadAllText(path));

            Console.ReadLine();
        }
    }
}
