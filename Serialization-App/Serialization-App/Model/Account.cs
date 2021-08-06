using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serialization_App.Model;

namespace AccountApp.Model
{
    [Serializable()]
    class Account
    {
        private int _accNo;
        private String _accName;
        private double _balance;

        public Account(int accNo, String accName) : this(accNo, accName, 500){}
        public Account(int accNo, String accName, double balance)
        {
            _accName = accName;
            _accNo = accNo;
            _balance = balance;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (_balance - amount < 500)
            {
                throw new Exception("Insufficient Balance");
                
            }
            _balance -= amount;
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public String AccountName
        {
            get
            {
                return _accName;
            }
            set
            {
                _accName = value;
            }
        }
        public override string ToString()
        {
            return "Account No: "+_accNo+" Account Name: "+_accName+"Account Balance: "+_balance;
        }
    }
}
