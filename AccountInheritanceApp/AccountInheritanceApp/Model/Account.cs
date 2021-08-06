using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountApp.Model
{
    abstract class Account
    {
        private int _accNo;
        private String _accName;
        protected Double _balance;
        public Account(int accNo,String accName,Double balance)
        {
            _accNo = accNo;
            _accName = accName;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public Double Balance
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
        public int AccountNo
        {
            get
            {
                return _accNo;
            }
            set
            {
                _accNo = value;
            }
        }
        
        public abstract void WithDraw(double amount);
    }
}
