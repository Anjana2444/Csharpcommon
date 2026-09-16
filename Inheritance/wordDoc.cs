using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class wordDoc:Document
    {
        public int DocId { get; set; }
        public string Title { get; set; }
        public override void Content()
        {
            Console.WriteLine("This word document is related to the upcoming events in the company");
        }

        public override void TimeToRead()
        {
            
            Console.WriteLine("This word document takes 15mins to read");
        }

    }
}
