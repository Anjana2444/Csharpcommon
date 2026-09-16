using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Pdf:Document
    {
        public string PdfName { get; set; }

        public override void Read()
        {
            base.Read();
            Console.WriteLine("Pdf : Document read Successfully");
        }

        public override void Write()
        {
            Console.WriteLine("Pdf: Document wrote successfully");
        }
    }
}
