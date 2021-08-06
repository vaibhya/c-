using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountApp.Model;

namespace AccountInheritanceApp.Model
{
    class SavingAccount : Account
    {
        public SavingAccount(int accNo, String accName) : base(accNo, accName, 500) { }
        public SavingAccount(int accNo,String accName,Double amount) : base(accNo,accName,amount)
        {

        }
        public override void WithDraw(double amount)
        {
            int minBalance = 1000;
            if (Balance - amount < minBalance)
            {
                throw new Exception("Saving account balance limit exceed!");
            }
            _balance = Balance - amount;
        }
    }
}
