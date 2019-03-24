using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class bank_account
    {

        Double user_amount;
        public int opt;

        public void diplay()
        {
            Console.WriteLine("\t\t***Welcome to my bank***");
            Console.WriteLine("\nAre you a member of my bank?");
            Console.WriteLine("Press Y for my member ");
            Console.WriteLine("Press N for new member ");
            char ans = Convert.ToChar(Console.ReadLine());
            switch (ans)
            {
                case 'y':
                    {
                        user_info();
                        break;
                    }
                case 'n':
                    {
                        intializing();
                        break;
                    }
            }
        }

        public void user_info()
        {
            string name;
            int account_num;
            Console.WriteLine("\nEnter your Account name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Account number:");
            account_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n1. You want to deposite");
            Console.WriteLine("2. You want to withdraw");
            Console.WriteLine("\nSelect your option");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        deposite();
                        break;
                    }
                case 2:
                    {
                        withdrawal();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Try again");
                        break;
                    }

            }
        }

        public void deposite()
        {
            Console.WriteLine("\nEnter your amounct you want to deposite");
            int bal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have sucessfully intered {0} ", bal + " in your account");
        }

        public void withdrawal()
        {
            Double credit;
            Console.WriteLine("\nEnter the amount you want to withdraw");
            credit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Its our company policy to deduct 2% from every withdraw amount inaccount of interest ");
            Double deducted_amount = (credit * 0.005);
            Console.WriteLine("Deducted amount is : {0}", deducted_amount);
            Double remaining_amount = credit - deducted_amount;
            Console.WriteLine("After deduction of 2% from your ammount reamining is {}", remaining_amount);
        }


        protected internal void intializing()
        {
            Console.WriteLine("\t\tStep 1");
            Console.WriteLine("\nFor Create an Account press 1");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Bank policy");
                Console.WriteLine("\nIt is mendatory for every account opening partner to have minimum Rs. 5000/- to open an account");
                Console.WriteLine("If you have required trems press 1");
                Console.WriteLine("If no so exit press 2");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    string user_name;
                    Console.WriteLine("\nEnter your name:");
                    user_name = Console.ReadLine();
                    Console.WriteLine("Enter your amount:");
                    int amount;
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (amount < 5000)
                    {
                        Console.WriteLine("\nInsufficient amount to crate an account");
                    }
                    else
                    {
                        Console.WriteLine("\nYour entered amount is: {0}", amount);
                        Console.WriteLine("You have sucessfully created an account in your bank");
                        Console.WriteLine("Your new account balance is");
                        Console.WriteLine("Thankyou");
                    }
                }
                else
                {
                    Console.WriteLine("\nSorry, you cannot become a part of My bank");
                }

            }
            else
            {
                Console.WriteLine("Exit");
            }

        }

        protected void interestrate()
        {
            Double Formula_for_interest = user_amount * 0.005;
        }

    }

}
