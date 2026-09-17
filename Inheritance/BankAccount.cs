using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal abstract class BankAccount
    {
        public double Balance { get; set; }

        public abstract double CheckBalance();

        public abstract void Withdraw(double amount);
        //private int accountnumber;
        public int Accountnumber { get; set; }

        //public int Accountnumber
        //{
        //    get { return accountnumber; }
        //    set { accountnumber = value; }
        //}


    }
}
