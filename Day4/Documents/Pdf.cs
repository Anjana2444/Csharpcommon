using System;
using System.Collections.Generic;
using System.Text;

namespace AllDocuments
{
    internal class Pdf : Document
    {
        public override void DocumentLocation()
        {
            Console.WriteLine("Notification sent!!");
        }
        public override void OpenDocument()
        {
            base.OpenDocument(); 
            Console.WriteLine("Pdf Opened!!");
        }
    }
}
