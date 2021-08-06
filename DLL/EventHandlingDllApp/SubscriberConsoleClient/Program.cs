using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublisherLib;

namespace SubscriberConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "vaibhav", 4000);
            account.BalanceChange += RefreshBalance;
            account.BalanceChange += PrintReceipt;
            account.BalanceChange += SendSms;
            account.Deposit(500);
            account.Withdraw(1000);
        }
        public static void RefreshBalance(Account acc)
        {
            Console.WriteLine("Refreshing Balance");
        }
        public static void PrintReceipt(Account acc)
        {
            Console.WriteLine("======================");
            Console.WriteLine("Dear " + acc.AccName + " \n Your updated balance is " + acc.Balance);
        }
        public static void SendSms(Account acc)
        {
            Console.WriteLine("Dear " + acc.AccName + " \n Your Account Balance is " + acc.Balance);
        }
    }
}
