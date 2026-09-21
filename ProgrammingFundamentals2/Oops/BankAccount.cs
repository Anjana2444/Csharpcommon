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


        //Encapsulation (Similar to public double Balance { get; set; })
        private int accountnumber;

        public int AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }


    }
}
