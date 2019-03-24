using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        string sname;
        int sAge;
        string course;

        public Class1(string _sname,int _sage,string _course)
        {
            sname = _sname;
            sAge = _sage;
            course = _course;

            Console.WriteLine("Name : "+sname+"Age :"+sAge+" and Course : "+course);
        }

    }
}
