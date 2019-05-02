using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awein_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome ATM Machine");
            Console.ReadLine();
            Console.Clear();
            ATM();
        }

        static void ATM ()
    {
        Console.WriteLine("Insert ATM Card and Press OK");
        
        String card = Console.ReadLine().ToLower();
        if (card=="ok")
        {
            Console.Clear();
            Console.WriteLine("\t Enter Amount");
            Console.WriteLine(@"Press 1 for Savings


Press 2 for Current");
            int data = Convert.ToInt32(Console.ReadLine());
            switch (data)
            {
                case 1:
                    Amount();
                    break;
                case 2:
                    Amount();
                    break;
                default:
                    Console.WriteLine("Card Block");
                    break;
            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Invalid Input Try Again");
                ATM();   
            }
        }
        
    
    }
        static void Amount()
        {
            Console.Clear();
            Console.WriteLine("Your account have RS 50,000");
            Console.WriteLine("Enter Amount for withdraw");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (amount<50000||amount>0)
            {
                
                Console.WriteLine("Your amount Rs"+amount+"is withdrawn");
            }
            else
            {
                Console.WriteLine("Sorry Your account balance is Low");
            }
        
        }
    }
}
