using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountInheritanceApp.Model;
using AccountApp.Model;

namespace AccountInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAcc1 = new SavingAccount(1, "vaibhav", 5000);
            savingAcc1.Deposit(500);
            try
            {
                savingAcc1.WithDraw(1000);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            printAccountInfo(savingAcc1);

            CurrentAccount currentAcc1 = new CurrentAccount(2, "atul", 1000);
            try
            {
                currentAcc1.WithDraw(1000);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            printAccountInfo(currentAcc1);
        }

        private static void printAccountInfo(Account savingAcc1)
        {
            Console.WriteLine(savingAcc1.Balance);
        }
    }
}
