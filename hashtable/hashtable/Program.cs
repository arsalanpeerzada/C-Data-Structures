using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Arsalan", 20);
            dic.Add("Hamas", 22);
            dic.Add("Asad", 21);

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
