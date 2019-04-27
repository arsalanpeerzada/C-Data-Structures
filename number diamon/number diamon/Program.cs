using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace number_diamon
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            int numberOfLines = numberOfRows - 3;
            int numOfSpaces = numberOfLines - 1;
            int numb = numberOfLines - numOfSpaces;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numOfSpaces; j++)
                {
                    Console.WriteLine("_");
                }
                Console.WriteLine(" ");

                for (int k = 0; k < numb; k++)
                {
                    Console.Write(k+1);
                }
            }

        }
    }
}
