using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace hashmap
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string path = "file.txt";

            string[] data = File.ReadAllLines(path);

            
            string[] Trim;

            string word = Console.ReadLine();
            foreach (var item in data)
            {
                Trim= item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < Trim.Length; i++)
                {
                    if (word == Trim[0])
                    {
                        Console.WriteLine("Word Found....!");
                        break;
                    }
                    
                }
            }
            Console.WriteLine("Word not Found");
            Console.ReadKey();
        }
    }
}
