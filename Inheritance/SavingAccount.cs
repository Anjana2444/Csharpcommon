using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class SavingAccount:BankAccount
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }

        public void SetName(string name)
        {
            FirstName = name;
        }

        public void SetName(string fname, string lname)
        { 
            FirstName = fname;
            LastName = lname;
        }
        public SavingAccount() 
        {
            Balance = 1000;
           
        }
        public override int CheckBalance()
        {
            return Balance;
        }

        public override void Widthdraw(int amount)
        {
            Balance = Balance - amount;
            Console.WriteLine($"{Balance}");
        }

     
        }
    }

