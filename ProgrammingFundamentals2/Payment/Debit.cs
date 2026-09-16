using System;
using System.Collections.Generic;
using System.Text;

namespace Payment
{
    internal class Debit: Payments
    {
        public int DebitID { get; set; }

        public void DebitPayment()
        {
            Console.WriteLine("Debit Card Transaction done by Anjana");
        }
        public override void SendNotification()
        {
            Console.WriteLine("Hi notification of debit card transaction");
        }
    }
}
