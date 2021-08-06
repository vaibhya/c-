using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandlingApp.Publisher
{
    public delegate void AccountHandler(Account acc);
    public class Account
    {
        private int _accountId;
        private String _accName;
        private Double _balance;

        public Account(int accountId,String accountName,Double balance)
        {
            _accountId = accountId;
            _accName = accountName;
            _balance = balance;
        }
        public event AccountHandler BalanceChanged;

        public void Deposit(Double amount)
        {
            _balance += amount;
            if (BalanceChanged != null)
            {
                BalanceChanged(this);
            }
        }
        public int AccountId
        {
            get { return _accountId; }
        }
        public String AccountName
        {
            get { return _accName; }
        }
        public Double AccountBalance
        {
            get { return _balance; }
        }
    }
}
