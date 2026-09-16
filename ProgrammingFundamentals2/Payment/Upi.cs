using System;
using System.Collections.Generic;
using System.Text;

namespace Payment
{
    internal class Upi: Payments
    {
        public int UpiId { get; set; }

        public void UpiPayment()
        {
            Console.WriteLine("UPI Transaction done by Anjana");
        }

        public override void Transaction() //can override
        {  
            base.Transaction(); //to implement the base function
            Console.WriteLine("Upi: Transaction Successfully Done");
        }

        public override void SendNotification()
        {
            Console.WriteLine("Hi notification of Upi transaction");
        }
    }
}
