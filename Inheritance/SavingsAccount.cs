using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class SavingsAccount : BankAccount
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SetName(string name)
        {
            FirstName = name;
        }

        public void SetName(string firstname, string lastname) 
        { 
            LastName = lastname;
            FirstName = firstname;
        }

        public SavingsAccount()
        {
            Balance = 1000;
            Accountnumber = 101;
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
