using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jungle_scenario
{
    class Animal:Functions
    {
        public void eat();
        public void speak();
    }
    class Lion : Animal 
    {
        public void eat()
        {
            Console.WriteLine("Eat Meat");
        }
        public void Speak()
        {
            Console.WriteLine("Com'on Em the King");
        }
    }
}
