using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace @try
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = "16/June/2008"; // <-- Valid
             
            DateTime fromDateValue;
            string s = @"15/07/2012 ";
            var formats = new[] { "dd/MMMM/yyyy" ,"yyyy-MM-dd" };
            if (DateTime.TryParse(s, out fromDateValue))
            {
                Console.WriteLine(fromDateValue);
            }
        }
    }
}
