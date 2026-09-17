using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    internal abstract class BankAccount
    {
        public double Balance { get; set; }
        public abstract double CheckBalance();
        public abstract void Withdraw(double amount);
        private int account_number;

        public int AccountNumber
        {
            get { return account_number; }
            set { account_number = value; }
        }
    }
}
