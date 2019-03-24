using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab_test
{
    class RW
    {
        string path = @"C:\Users\Arsalan peerzada\Desktop\waqar bhai assignment\6humanCodedDataSets\6humanCodedDataSets\rw1046.txt";

        List<string> list = new List<string>();
        public void sort()
        {
            string[] data = File.ReadAllLines(path);
            foreach (var item in data)
            {
                string[] Trim = item.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item1 in Trim)
                {
                    if (!list.Contains(item1))
                    {
                        list.Add(item1);
                    }
                }
            }
        }
    }
}
