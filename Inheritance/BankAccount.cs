using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal  abstract class BankAccount
    {
        public int Balance { get; set; }

        public abstract void Widthdraw(int amount);

        public abstract int CheckBalance();

        private int accountNo;

        public int AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }




    }
}
