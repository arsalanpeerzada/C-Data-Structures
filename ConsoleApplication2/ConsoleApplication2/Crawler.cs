using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace ConsoleApplication2
{
    class Crawler
    {

        public string HTMLScraper(string URL)
        {

            WebClient client = new WebClient();
            string HTMLData = client.DownloadString(URL);
            return HTMLData;
        }


    }
}
