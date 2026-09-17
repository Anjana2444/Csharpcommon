using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    internal class SavingsAccount : BankAccount
    {
        public string Name { get; set; }
        public void SetName(string first_name)
        {
            Name = first_name;
            Console.WriteLine($"Name: {Name}");
        }
        public void SetName(string first_name, string last_name)
        {
            Name = first_name + " " + last_name;
            Console.WriteLine($"Full Name: {Name}");

        }
        public SavingsAccount()
        {
            Balance = 10000;
            AccountNumber = 1426;
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
