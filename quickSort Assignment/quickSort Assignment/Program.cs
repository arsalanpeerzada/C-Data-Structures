using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quickSort_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(40);
            list.Add(20);
            list.Add(10);
            list.Add(80);
            list.Add(60);
            list.Add(50);
            list.Add(7);
            list.Add(30);
            list.Add(100);
            int left = 0;
            int right = list.Count - 1;
            int loc = 0;

            search obj = new search();
            obj._search(list, left, right, loc);


        }
    }
}
