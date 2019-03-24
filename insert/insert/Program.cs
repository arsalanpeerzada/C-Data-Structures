using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace inserting_sorting_searching
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            List<string> list2 = new List<string>();

            for (int i = 0; i < 25; i++)
            {
                int a = rnd.Next(1, 200);
                if (list.Contains(a))
                {
                    list.Add(rnd.Next(20, 900));
                }
                else
                {
                    list.Add(a);
                }
            }

            Console.WriteLine("Done Inserting.....!");
            int temp;

            for (int i = 0; i < list.Count; i++)
            {
                for (int sort = 0; sort < list.Count - 1 - i; sort++)
                {
                    if (list[sort] > list[sort + 1])
                    {
                        temp = list[sort + 1];
                        list[sort + 1] = list[sort];
                        list[sort] = temp;
                    }
                }
            }

            Console.WriteLine("\nDone Sorting.......!");
            //string path = @"insert_sort_search.text";
            //Console.Write("Enter Number : ");
           // int numb = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                list2.Add(list[i].ToString());
                Console.WriteLine(list2[i]);
            }

            
            File.WriteAllLines("abcd.txt", list2);

            Console.WriteLine("Done......!");
        }
    }
}
