using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal  abstract class Payment
    {
        public string PaymentArea { get; set; }
        public abstract void SendNotification();
        

        public virtual void  Transaction()
        {
            Console.WriteLine(" Parent:Transaction Sucessfully Done");
        }
    }
}
