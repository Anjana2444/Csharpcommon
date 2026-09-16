using System;
using System.Collections.Generic;
using System.Text;

namespace Payment
{
    internal class Credit: Payments
    {
        public int CreditID { get; set; }
        public void CreditPayment()
        {
            Console.WriteLine("Credit card Transaction done by Anjana");
        }

        public override void SendNotification()
        {
            Console.WriteLine("Hi notification of credit card transaction");
        }
    }
}
