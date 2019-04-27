using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace waqar_bhai_lab_test_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> IndexDic = new Dictionary<string, Dictionary<string, List<string>>>();

            Dictionary<string, List<string>> a_dic = new Dictionary<string, List<string>>();

            List<string> words = new List<string>();

            string[] dir_list = Directory.GetFiles(@"C:\Users\Arsalan peerzada\Desktop\waqar bhai assignment\6humanCodedDataSets\6humanCodedDataSets\");
            
            string data;
            string[] Trim;
            char[] cha = { ' ', ',', '=', '%', '\t', '\n', '\r', '?', '.', '-', '=', '(', ')' };
            int ascii = 97;
            string[] filename;
            foreach (var item in dir_list)
            {
                

                data = File.ReadAllText(item).ToLower();
                Trim = data.Split(cha, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < Trim.Length; j++)
                    {
                        if (Convert.ToInt32(Trim[j][0])==ascii)
                        {
                            words.Add(Trim[j]);
                        }
                    }

                    a_dic.Add(ascii.ToString(), words);
                    words = new List<string>();
                    if (ascii<122)
                    {
                        ascii++;
                    }
                    else
                    {
                        ascii = 97;
                    }
                }

                IndexDic.Add(item, a_dic);
                a_dic = new Dictionary<string, List<string>>();
            }

        }
    }
}
