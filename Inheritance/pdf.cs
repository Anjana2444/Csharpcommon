using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class pdf:Document
    {
        public int PdfId { get; set; }
        public string Title { get; set; }
        public override void Content()
        {
            Console.WriteLine("This pdf is related to the policy of the company");
        }
        public override void TimeToRead()
        {
            base.TimeToRead();
            Console.WriteLine("This pdf takes 10 mins to read");
        }
    }
}
