using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a= " ";
            sta sta1 = new sta();
            sta1.Push("m");
            sta1.Push("a");
            sta1.Push("d");
            sta1.Push("a");
            sta1.Push("m");

            int counting = sta1.GetCount();

            for (int i = 0; i < counting; i++)
            {
                 a += sta1.Pop();
            }

            if (a=="madam")
            {
                Console.WriteLine("This is Palidrom of {0}",a);
            }
           
        }
    }
}
