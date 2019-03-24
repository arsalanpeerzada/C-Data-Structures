using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Destructor
{
    class Constructor
    {
        public void Construct()
        {
            Console.WriteLine("Hello World , This is Constructor is calling");
        }

        ~ Constructor()
        {
            Console.WriteLine("Bye World , This is Destructor Calling");
        }
    }
}
