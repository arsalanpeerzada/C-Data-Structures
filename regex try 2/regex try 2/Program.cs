using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace regex_try_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Arsalan peerzada\Desktop\text.txt";
            string[] trim;
            int count = 0;
            DateTime date;
            List<string> list = new List<string>();
            List<string> newList = new List<string>();
            string[] number = File.ReadAllLines(path);

            string format = "%d";
            string format2 = "%yyyy";

            string spattern = @"^\d+";

            foreach (string s in number)
            {
                count++;
                trim = s.Split(new[] { '\"', '/', '<', '>', ',', ' ', '-', '.', '{', '}', }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < trim.Length; i++)
                {
                    if (Regex.IsMatch(trim[i], spattern))
                    {
                        list.Add(trim[i]);
                    }
                }

            }

            for (int i = 0; i < list.Count - 2; i++)
            {

                if (DateTime.TryParseExact(list[i], format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    if (DateTime.TryParseExact(list[i+1], format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        if (DateTime.TryParseExact(list[i + 2], format2, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                        {
                            newList.Add(list[i] + "-" + list[i + 1] + "-" + list[i + 2].ToString());
                            i = i + 2;
                        }
                    }
                }
            }

            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }
        }
    }
}
