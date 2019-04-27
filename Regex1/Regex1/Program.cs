using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Text.RegularExpressions;

namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = @"My date of birth is 1/10/2012,my 12/2/2015 and 5/7/2000";

            List<string> logDates = new List<string>();

            //Define regex string
            string pattern = @"(?<logDate>(\d){4}-(\d){2}-(\d){2}\s(\d){2}:(\d){2}:(\d){2})";
            Regex reg = new Regex(pattern);

            //read log content
            string logContent = File.ReadAllText(@"C:\Users\Arsalan peerzada\Desktop\text.txt");

            //run regex
            MatchCollection matches = reg.Matches(pattern);


            //iterate over matches
            foreach (Match m in matches)
            {
                DateTime logTime = DateTime.Parse(m.Groups["logDate"].Value);
                logDates.Add(logTime.ToString());

                for (int i = 0; i < m.Length; i++)
                {
                    Console.WriteLine(logDates);
                }
            }

            

            //show first and last entry
            //Console.WriteLine("First: " + logDates.First());
            //Console.WriteLine("Last: " + logDates.Last());
        }
    }
}
