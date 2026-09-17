using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMethod
{
    internal class CreditCard : Payment
    {
        public int CardNumber { get; set; }
        public void CreditCardPayment()
        {
            Console.WriteLine("Payemnt done through credit card");
        }
        public override void Transaction()
        {
            Console.WriteLine("Sub Class: Payment Successfull through credit card!!!");
        }
        public override void SendNotification()
        {
            Console.WriteLine("Done Payment Through Credit Card");
        }
    }
}
