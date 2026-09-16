using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMethod
{
    internal abstract class Payment
    {
        public int PaymentId { get; set; }
        public abstract void SendNotification();

        public virtual void Transaction() //polymorphism
        {
            Console.WriteLine("parent : Transaction complete");
        }
    }
}
