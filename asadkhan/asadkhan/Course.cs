using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asadkhan
{
    class Course
    {
        string studentName;
        string courseName;
        int courseID;
        int roll_Numb;
        string TA_Name;
        string teacherName;

        public void setMethod(string _sName, string _cName, int _cID, int _rNumb, string _TA, string _tname)
        {
            studentName = _sName;
            courseName = _cName;
            courseID = _cID;
            roll_Numb = _rNumb;
            TA_Name = _TA;
            teacherName = _tname;
        }

        public void print()
        {
            Console.WriteLine("Course Name is {0} and Course ID is {1}",courseName,courseID);
        }
        public void print(string name)
        {
            Console.WriteLine("Student Name is {0} and Student ID is {1}",studentName,roll_Numb);
        }
        public void print(string name,int numb)
        {
            Console.WriteLine("Teacher Name is {0} and TA Name is {1}",teacherName,TA_Name);
        }
    }
}
