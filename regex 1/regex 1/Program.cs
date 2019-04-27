using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace regex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hp\Desktop\My.txt";
            int count = 0;
            string[] number = File.ReadAllLines(path);

            //string sPattern = "^\\d{2}-\\d{2}-\\d{4}$";
            //string pattern = "^\\d{2} \\d{2} \\d{4}$";
            //string sspattern = "^\\d{1}-\\d{2}-\\d{4}$";
//            string patternss = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)
//(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?
//(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])
//(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";

            string spattern = @"^\d+";

            foreach (string s in number)
            {
                count++;
                string [] trim = s.Split(new [] { '\"','/','<','>',',',' ','-','.','{','}', },StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < trim.Length; i++)
                {
                    if (Regex.IsMatch(trim[i], spattern))
                    {
                        Console.Write("{0,14}", trim[i]);
                        Console.WriteLine(" - valid");
                    }
                //    if (Regex.IsMatch(trim[i],sPattern))
                //    {
                //        Console.Write("{0,14}", trim[i]);
                //        System.Console.WriteLine(" - valid");
                //    }
                //    else if (Regex.IsMatch(trim[i], pattern))
                //    {
                //        Console.Write("{0,14}", trim[i]);
                //        System.Console.WriteLine(" - valid");
                //    }
                //    else if (Regex.IsMatch(trim[i], sspattern))
                //    {
                //        Console.Write("{0,14}", trim[i]);
                //        System.Console.WriteLine(" - valid");
                //    }
                //    else if (Regex.IsMatch(trim[i], patternss))
                //    {
                //        Console.WriteLine("{0,14}",trim[i]);
                //        Console.WriteLine(" - valid");
                //    }
                //else
                //{
                //    Console.Write("{0,14}", trim[i]);
                //    System.Console.WriteLine(" - invalid");
                //}
                }
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            Console.WriteLine(count);
            System.Console.ReadKey();
        }
    }
}

