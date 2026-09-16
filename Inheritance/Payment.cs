using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal abstract class Payment
    {
        public int Paymentid { get; set; }
        public virtual void Transaction() {
            Console.WriteLine("Parent: Transaction completed Successfully");
        }

        public abstract void SendNotification();
    }
}
