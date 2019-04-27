using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace target_searcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbwer : ");
            int target = Convert.ToInt32(Console.ReadLine());
            string possition=" ";
            int [] array=new int[5];

            array[0]=5;
            array[1]=6;
            array[2]=3;
            array[3]=6;
            array[4]=1;

            for (int i = 0; i < array.Length; i++)
            {
                if (target==array[i])
                {
                    possition = i.ToString();
                    Console.WriteLine("Number Found at {0} ",i+1);
                }
            }
            Console.WriteLine(possition);
           // Console.WriteLine("Number found at: "+possition);
            Console.ReadLine();
        }
    }
}
