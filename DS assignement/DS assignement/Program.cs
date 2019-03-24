using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DS_assignement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Arsalan peerzada\Desktop\text.txt";

            int length = 0;
            // string input = Console.ReadLine();
            DateTime dateTime;
            string[] Trim;
          //  string[] arr;
            string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt", 
                   "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss", 
                   "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt", 
                   "M/d/yyyy h:mm", "M/d/yyyy h:mm", 
                   "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm", "dd MM yyyy","dd MMMM yyyy",
                   "dd M yyyy","ddd M yyyy","ddd MMMMM yyyy","ddd MM yyyy","dddd M yyyy",
                     "dddd MM yyyy" ,"dddd MMMM yyyy","dd-MM-yyyy","dd-MMMM-yyyy","dd-M-yyyy"
                               ,"d MMMM yyyy "};
           
            List<string> list = new List<string>();
            //WebClient obj = new WebClient();
            // obj.DownloadFile("http://en.wikipedia.org/wiki/" + input,path);

            string[] data = File.ReadAllLines(path);

            foreach (var item in data)
            {
                Trim = item.Split(new[] { ' ', '=', '\"', '/', '>', '<', ',', '.', ':'} , StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Trim.Length; i++)
                {
                    if (!list.Contains(Trim[i], StringComparer.OrdinalIgnoreCase))
                    {
                        list.Add(Trim[i]);

                    }
                }

                for (int i = 0; i < data.Length; i++)
                {
                    if ((DateTime.TryParseExact(item, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime)))
                    {
                        Console.WriteLine(list[i]);
                    }
                }
            }

           

        }

    }
}