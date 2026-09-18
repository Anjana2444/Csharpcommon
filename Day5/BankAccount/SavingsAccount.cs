using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    internal class SavingsAccount : BankAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public SavingsAccount()
        {
            Balance = 1000;
        }

        public void SetName(string name)
        {
            FirstName = name;
        }

        public void SetName(string firstname, string lastname) //method overloading method overloading
        {
            LastName = lastname;
            FirstName = firstname;
        }
        public override double CheckBalance()
        {
            return Balance;
        }

        public override void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Not enough Balance");
            }
            else
            {
                Balance = Balance - amount;
            }
        }

    }
}
