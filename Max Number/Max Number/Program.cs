using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0;
            int loc=1;
            int [] data = new int[5];
            int max = data[0];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (k=0; k < data.Length; k++)
            {
                if (max<=data[k])
                {
                    max = data[k];
                    loc = k+1;
                }
                
            }

            Console.WriteLine("Max Number is {0} at Locataion {1}",max,loc);
            Console.ReadLine();
        }
    }
}
