using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
           // bool choose = true;
            Stack obj = new Stack();
            //char choice= ' ';
           // string name = Console.ReadLine();

            obj.Push("Waqar");

            int count = obj.GetCount();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(obj.Pop());
            }
        }
    }
}
