using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace ds_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Arsalan peerzada\Desktop\Pakistan.txt";
            List<string> list = new List<string>();
            string[] data = File.ReadAllLines(path);

            foreach (var item in data)
            {
                string output = Regex.Match(item, @"\d+").Value;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
