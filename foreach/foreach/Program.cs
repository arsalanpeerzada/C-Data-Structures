using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // An unsorted string array.
            string[] letters = { "dash", "cat", "alpha", "boot" };
            // Use LINQ query syntax to sort the array alphabetically.
            var sorted = from letter in letters
                         orderby letter
                         select letter;
            // Loop with the foreach keyword.
            foreach (string value in sorted)
            {
                Console.WriteLine(value);
            }
        }
    }
}
