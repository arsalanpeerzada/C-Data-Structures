using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_oop
{
    class Physics
    {
        public string Calculation(decimal distance,decimal time)
        {
            Console.WriteLine("===First calculation===");
            Console.WriteLine();
            Console.WriteLine("Enter distance");
           distance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter time");
           time = Convert.ToDecimal(Console.ReadLine());
           decimal velocity = distance / time ;
            decimal v = decimal.Round(velocity, 2);
            Console.WriteLine();


            return "The velocity is: " + v;
        }
        public string Calculation(int distance,int time,int Atime)
        {

            Console.WriteLine("===Second calculation===");
            Console.WriteLine();
            Console.WriteLine("Enter distance");
            decimal d1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter time");
            decimal t1 = Convert.ToDecimal(Console.ReadLine());
            decimal velocity1 = d1 / t1;
            decimal v1 = decimal.Round(velocity1, 2);
            Console.WriteLine("First velocity is :"+ v1);
            Console.WriteLine();
            Console.WriteLine("Enter distance");
            decimal d2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter time");
            decimal t2 = Convert.ToDecimal(Console.ReadLine());
            decimal velocity2 = d2 / t2;
            decimal v2 = decimal.Round(velocity2, 2);
            Console.WriteLine("Second velocity is :" + v2);
            Console.WriteLine("Now enter accelerating time");
            decimal T = Convert.ToDecimal(Console.ReadLine());
            decimal acceleration = (v2 - v1) / T;
            decimal A = decimal.Round(acceleration, 2);
            Console.WriteLine();


            return "Acceleration is: "+A;
        }


    }
}
