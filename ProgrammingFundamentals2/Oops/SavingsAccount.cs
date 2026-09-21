using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class SavingsAccount:BankAccount
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //function Overloading
        public void SetName(string name)
        {
            Firstname = name;
        }

        public void SetName(string fname, string lname)
        {  
            Firstname = fname;
            Lastname = lname; 
        }
        public SavingsAccount()
        {
            Balance = 5000000;
            AccountNumber = 123; //in Encapsulation we cannot access through the property name , but can be accessed through function name.
        }
        public override double CheckBalance()
        {
            return Balance;
        }

        public override void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }
    }
}
