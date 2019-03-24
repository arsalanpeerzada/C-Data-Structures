using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            bank_account obj_of_bank = new bank_account();
            obj_of_bank.diplay();
           // obj_of_bank.user_info();
            Console.ReadKey();
        }
    }
}
