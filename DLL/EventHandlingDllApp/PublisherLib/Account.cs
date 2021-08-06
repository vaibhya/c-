using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublisherLib
{
    public delegate void AccountHandler(Account acc);
    public class Account
    {
        private int _accId;
        private String _accName;
        private Double _balance;
        public Account(int accId,String accName,Double balance)
        {
            _accId = accId;
            _accName = accName;
            _balance = balance;
        }
        public event AccountHandler BalanceChange;
        public void Deposit(int amount)
        {
            this._balance += amount;
            if (BalanceChange != null)
            {
                BalanceChange(this);
            }
        }
        public void Withdraw(int amount)
        {
            if (_balance - amount < 500)
            {
                throw new Exception("You have exceeded balance limit!");
            }
            this._balance -= amount;
            if (BalanceChange != null)
            {
                BalanceChange(this);
            }
        }
        public int AccId
        {
            get { return _accId; }
        }
        public String AccName
        {
            get { return _accName; }
        }
        public Double Balance
        {
            get { return _balance; }
        }
    }
}
