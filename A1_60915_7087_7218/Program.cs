using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Globalization;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            string array = @"C:\Users\KHAN\Desktop\as.txt";
            string[] _array = File.ReadAllLines(array);
            string[] splitArray;
            List<string> list = new List<string>(); 
            foreach (var item in _array)
            {
                splitArray = item.Split(new[] { ' ', '=', '\"', '/', '>', '<', ',', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string[] digits = Regex.Split(array, @"\D+");
                for (int i = 0; i < splitArray.Length; i++)
                {
                    if (!list.Contains(splitArray[i], StringComparer.OrdinalIgnoreCase))
                    {
                        list.Add(splitArray[i]);

                    }
                }
                 foreach (string value in digits)
                 {

                     int number;
                     if (int.TryParse(value, out number))
                     {
                         Console.WriteLine(value);
                     }
                 }
               
            }
          
           



           
          
            
        }
    }
}
