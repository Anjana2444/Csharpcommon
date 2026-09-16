using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Upi:Payment
    {
        public int UpiId { get; set; }

        public void UpiPaymentDone() {
            Console.WriteLine("Upi payment done successfully");

        }
        public override void Transaction()
        {
            base.Transaction();
            Console.WriteLine("upi: Transaction completed Successfully");
        }
        public override void SendNotification() {
            Console.WriteLine("Upi: Notification Sent.");
        }
    }
}
