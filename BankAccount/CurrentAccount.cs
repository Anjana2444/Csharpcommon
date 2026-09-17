using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    internal class CurrentAccount : BankAccount
    {

        public CurrentAccount()
        {
            Balance = 52000;
        }
        public override double CheckBalance()
        {
            return Balance;
        }

        public override void Withdraw(double amount)
        {
            Balance = Balance - amount - 10;
        }
    }
}
