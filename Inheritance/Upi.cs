using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class Upi:Payment
    {
        public int UpiId { get; set; }

        public void UpiPayment()
        {
            Console.WriteLine("Payment done through Upi");
        }
        public override void SendNotification()
        {
            Console.WriteLine("Done");
        }
        public override void Transaction()
        {
            base.Transaction();
            Console.WriteLine(" Upi: Transaction Sucessfully Done");
        }
    }
}
