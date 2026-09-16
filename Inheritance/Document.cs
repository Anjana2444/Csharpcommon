using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal abstract class Document
    {
        public int DocumentId { get; set; }
        public int Pages { get; set; }
        public void DisplayPageNo ()
        {
            Console.WriteLine($"The no of pages are:{Pages}");
        }
        public abstract void Content();
        public virtual void TimeToRead()
        {
            Console.WriteLine("It takes minimum of 5 minitues to read a document");
        }
    }
}
