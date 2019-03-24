using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace readAndwrite
{
    class Program
    {
        static void Main(string[] args)
        {


            File.WriteAllLines("BackUp 28-1-15.txt",new string[]{"sufyan","umar","paf","kiet"});
        }
    }
}
