using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace Twitter_WebCrawler
{
    class Crawler
    {
        string path = @"HashtagFile.txt";
        public void hash()
        {
            Console.Write("Write Hashtag:  ");
            string hash=Console.ReadLine();
            WebClient client = new WebClient();
            client.DownloadFile(@"https://WWW.twitter.com/hashtag/" + hash,path);

            string[] data = File.ReadAllLines(path);
        }
    }
}
