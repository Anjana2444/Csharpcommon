using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class WordDoc:Document
    {
        public string WordName { get; set; }

        public override void Read()
        {
            Console.WriteLine("WordDoc : Document read Successfully");
        }

        public override void Write()
        {
            Console.WriteLine("Worddoc: Document wrote successfully");
        }
    }
}
