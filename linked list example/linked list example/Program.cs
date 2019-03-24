using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linked_list_example
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lnlist = new LinkedList<string>();
            lnlist.AddLast("Arsalan");
            lnlist.AddLast("Hamas");
            lnlist.AddLast("Asad");
            lnlist.AddFirst("First");

            LinkedListNode<string> node = lnlist.Find("Hamas");
            lnlist.Remove(node);

            foreach (var item in lnlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
