using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class DebitCard:Payment
    {
        public int CardNumber { get; set; }

        public void CardPayment()
        {
            Console.WriteLine("done via Debit card");
        }
        public override void SendNotification()
        {
            Console.WriteLine("Done sucess");
        }
    }
}
