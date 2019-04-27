using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to Enter Name If Yes press Y/y");

            Class1 newobject = new Class1();
            string choice = Console.ReadLine();
            if (choice=="Y" || choice=="y")
            {
                string name = Console.ReadLine();
                string model = Console.ReadLine();
                string speed = Console.ReadLine();
                int year = Convert.ToInt32(Console.ReadLine());
                newobject.setMethod(name, model, year, speed);
            }

            newobject.get();
        }
    }
}
