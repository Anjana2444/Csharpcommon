using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class CurrentAccount:BankAccount
    {
        public CurrentAccount()
        {
            Balance = 2000;
        }
        public override double CheckBalance()
        {    

            return Balance;

        }

        public override void Withdraw(double amount)
        {
            Balance = Balance - amount;
            Balance = Balance - 10;
        }
    }
}
