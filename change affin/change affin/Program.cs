using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace change_affin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Arsalan peerzada\Desktop\urdu_afinn.txt";

            string[] data = File.ReadAllLines(path);
            List<string> list = new List<string>();

            //for (int i = 0; i < data.Length; i++)
            //{
            //    data[i] = Regex.Split(data[i], @"\D+");
            //}
            
        }
    }
}
