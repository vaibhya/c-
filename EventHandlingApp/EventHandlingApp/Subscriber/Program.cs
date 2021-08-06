using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventHandlingApp.Publisher;

namespace EventHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "vaibhav", 4000);
            account.BalanceChanged += RefreshBalance;
            account.BalanceChanged += PrintReceipt;
            account.BalanceChanged += SendSms;
            account.Deposit(500);
        }
        public static void RefreshBalance(Account acc)
        {
            Console.WriteLine("Refreshing the account balance "+ acc.AccountName);
        }
        public static void PrintReceipt(Account acc)
        {
            Console.WriteLine("============");
            Console.WriteLine("Printing Receipt: \n Account Name: " + acc.AccountName + "\n Account Number: " + acc.AccountId + " \n Account Balance: " + acc.AccountBalance);
        }
        public static void SendSms(Account acc)
        {
            Console.WriteLine("===========");
            Console.WriteLine("Dear " + acc.AccountName+" \n Your account balance is: "+acc.AccountBalance);
        }
    }
}
