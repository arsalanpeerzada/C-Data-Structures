using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace words_breaking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Arsalan";
            string[] arr = new string[name.Length];
            int count=0;
            foreach (var item in name)
            {
                arr[count] = item.ToString();
                count++;
            }

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
