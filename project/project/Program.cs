using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
           // string path = @"C:\Users\Arsalan peerzada\Desktop\urdu_anew2.txt";

          //  string[] data = File.ReadAllLines(path);

            //string[] Trim;

            string[] Cut;

          //  string input = Console.ReadLine();
            Dictionary obj = new Dictionary();

            string [] reading= File.ReadAllLines(@"C:\Users\Arsalan peerzada\Desktop\Urdu Tweets.txt");
            string [] readings= {"آپ بہت اچھے ہیں"," آپ بہت گندے ہیں"," اغوا"," زبردست"};
            foreach (var item in readings)
            {
                Cut = item.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                obj.search(Cut);
            }
           
        }
    }
}
