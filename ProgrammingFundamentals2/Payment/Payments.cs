using System;
using System.Collections.Generic;
using System.Text;

namespace Payment
{
    internal abstract class Payments
    {
        public int PaymentId { get; set; }
        public abstract void SendNotification(); //must implement

        public virtual void Transaction() //can override
        {
            Console.WriteLine("Parent: Transaction Successfully Done");
        }

        public void DisplayDetails()
        {
            Console.WriteLine(this.PaymentId);
        }
        
    }
}
