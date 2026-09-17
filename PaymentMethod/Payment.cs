using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMethod
{
    internal abstract class Payment
    {
        public int PurchaseID { get; set; }
        public virtual void Transaction()
        {
            Console.WriteLine("Parent Class: Payment Successfull!!!");
        }
        public abstract void SendNotification();

    }
}
