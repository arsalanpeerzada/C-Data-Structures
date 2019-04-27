using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vowel_Checker
{
    class Class1
    {
        string name;
        string input;
        int no_of_vowel;

        public string user_name()
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine().ToLower();
            return name;
        }
        public int vowel()
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'A' || name[i] == 'e' || name[i] == 'E' || name[i] == 'i'
                    || name[i] == 'I' || name[i] == 'o' || name[i] == 'O' || name[i] == 'u' || name[i] == 'U')
                {
                    no_of_vowel++;
                }
            }
            return no_of_vowel;
        }

    }
}
