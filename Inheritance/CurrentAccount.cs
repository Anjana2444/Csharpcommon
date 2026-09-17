using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class CurrentAccount:BankAccount
    {

        public CurrentAccount()
        {
            Balance = 2000;
        }
        public override int CheckBalance()
        {
            return Balance;
        }

        public override void Widthdraw(int amount)
        {
            Balance = Balance - amount;
            Balance = Balance - 10;
        }


    }
}
