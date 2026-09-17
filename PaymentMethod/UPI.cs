using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMethod
{
    internal class UPI : Payment
    {
        public int UpiID { get; set; }
        public void UpiPayment()
        {
            Console.WriteLine("Payment Done through UPI");
        }
        public override void Transaction()
        {
            Console.WriteLine("Sub Class: Payment Successfull through UPI!!!");
        }
        public override void SendNotification()
        {
            Console.WriteLine("Done Payment Through UPI");
        }
    }
}
