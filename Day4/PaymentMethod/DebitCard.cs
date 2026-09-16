using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMethod
{
    internal class DebitCard : Payment
    {
        public int CardNumber { get; set; }

        public override void SendNotification()
        {
            Console.WriteLine("Notification sent!!");
        }
        public void CardStatus()
        {
            Console.WriteLine("Payment declined ");
        }
    }
}
