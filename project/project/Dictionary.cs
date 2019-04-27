using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace project
{
    class Dictionary
    {
        string path = @"C:\Users\Arsalan peerzada\Desktop\Urdu_anew2.txt";

        string[] Trim;

        public void search(string [] word)
        {
            string[] data = File.ReadAllLines(path);

            foreach (var item in data)
            {
                Trim = item.Split(new[] { '\t', '\"' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Trim.Length; i++)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (Trim[i]==word[j])
                        {
                            Console.WriteLine(word[j]);
                           // return word[j];
                        }
                    }
                }
            }
        }
    }
}
