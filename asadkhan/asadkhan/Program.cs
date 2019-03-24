using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asadkhan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t WelCome to PAF-KIET");
            string name = Console.ReadLine();
            string teacherName = Console.ReadLine();
            string taName = Console.ReadLine();
            int RollNo = Convert.ToInt32(Console.ReadLine());
            string courseName = Console.ReadLine();
            int courseID = Convert.ToInt32(Console.ReadLine());

            Course obj = new Course();
            obj.setMethod(name, courseName, courseID, RollNo, taName, teacherName);
            obj.print();
            obj.print(name);
            obj.print(name, RollNo);
        }
    }
}
