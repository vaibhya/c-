using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountApp.Model;

namespace AccountInheritanceApp.Model
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accNo,String accName) : base(accNo, accName, 500) { }
        public CurrentAccount(int accNo,String accName,Double balance) :base(accNo, accName,balance)
        {
            AccountName = accName;
            AccountNo = accNo;
            _balance = balance;
        }
        public override void WithDraw(double amount)
        {
            int minBalance = 500;
            if (Balance - amount < minBalance)
            {
                throw new Exception("Current Account limit Exceed!");
            }
        }
    }
}
