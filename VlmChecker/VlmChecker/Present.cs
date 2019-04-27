using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VlmChecker
{
    class Present
    {
        public List<string> Checker()
        {
            string path = @"C:\Users\Hp\Desktop\VLM Assignment\";

            

            string[] data = Directory.GetFiles(path, @"*.*");
            string[] Trim;
            List<string> list = new List<string>();
            List<string> check = new List<string>();
            foreach (var item in data)
            {
                Trim = item.Split(new char[] { '[', ']',',', '{', '}', '_',')','(','\\', '\t', '\"', '-' ,'.'}, StringSplitOptions.RemoveEmptyEntries);

                if (!check.Contains(Trim[5]))
                {
                    check.Add(Trim[5]);
                    list.Add(Trim[5]+"\t"+","+Trim[6]);
                }

            }

            return list;
            
        }
    }
}
