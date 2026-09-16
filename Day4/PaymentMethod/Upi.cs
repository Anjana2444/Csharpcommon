using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMethod
{
    internal class Upi : Payment
    {
        public int UpiId { get; set; }
        public void UpiPayment()
        {
            Console.WriteLine("Payment Done!!");
        }
        public override void SendNotification()
        {
            Console.WriteLine("Notification sent!!");
        }
        public override void Transaction()
        {
            base.Transaction(); //calls parent call
            Console.WriteLine("Upi :Transaction completed!!");
        }
    }
}
