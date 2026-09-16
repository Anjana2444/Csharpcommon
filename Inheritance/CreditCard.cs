using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class CreditCard:Payment
    {
        public int CreditCardId { get; set; }

        public void CreditCardPaymentDone()
        {
            Console.WriteLine("Credit Card Payment done successfully");
        }

        public override void SendNotification()
        {
            Console.WriteLine("credit card: Notification Sent.");
        }
    }
}
