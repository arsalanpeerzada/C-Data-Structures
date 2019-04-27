using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace New_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Arsalan peerzada\Desktop\VLM RESULT\";

            string[] data = File.ReadAllLines(path+"Book1.txt");

            string[] data2 = File.ReadAllLines(path+"Book2.txt");

            string[] Trim;
            string[] Trim2;
            List<string> list = new List<string>();
            foreach (var item in data)
            {
                Trim = item.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item2 in data2)
                {
                    Trim2 = item2.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (Trim[0]==Trim2[0])
                    {
                        list.Add(Trim[0] + "\t" + Trim[1] + "\t" + Trim[2] + "\t" + Trim2[2]);
                        
                    }
                    
                }
            }

            
        }
    }
}
