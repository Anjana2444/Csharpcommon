using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMethod
{
    internal class DebitCard : Payment
    {
        public int CardNumber { get; set; }
        public void DebitCardPayment()
        {
            Console.WriteLine("Payemnt done through debit card");
        }
        public override void Transaction()
        {
            Console.WriteLine("Sub Class: Payment Successfull through debit card!!!");
        }
        public override void SendNotification()
        {
            Console.WriteLine("Done Payment Through Debit Card");
        }
    }
}
