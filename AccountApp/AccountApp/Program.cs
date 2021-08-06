using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountApp.Model;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1, "Vaibhav");
            account1.Deposit(1000);
            printInfo(account1);
            try
            {
                account1.Withdraw(1100);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            printInfo(account1);

            Account account2 = new Account(2, "Atul", 5000);
            printInfo(account2);
        }

        private static void printInfo(Account account1)
        {
            Console.WriteLine(account1.Balance);
        }
    }
}
