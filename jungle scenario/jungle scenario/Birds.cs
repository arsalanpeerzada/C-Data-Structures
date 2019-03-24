using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jungle_scenario
{
    abstract class Birds:Functions
    {
        void eat()
        {
            Console.WriteLine("Grains");
        }
        public void speak;
        public void flying;
    }
    class Parrot : Birds
    {
        public void eat();
        
    }
    class Pigeon : Birds
    {
 
    }
}
