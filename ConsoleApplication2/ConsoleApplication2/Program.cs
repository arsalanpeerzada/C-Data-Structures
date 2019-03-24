using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {


            Crawler c1;
            c1 = new Crawler();
            c1.HTMLScraper(@"http://www.amazon.com/dp/B00CX5P8FC/ref=br_imp_ara-1/180-1896195-8521411?pf_rd_m=ATVPDKIKX0DER&pf_rd_s=desktop-hero-1&pf_rd_r=0QP933N7Z3Q3EF66W0YE&pf_rd_t=36701&pf_rd_p=2026083542&pf_rd_i=desktop");



        }
    }
}
