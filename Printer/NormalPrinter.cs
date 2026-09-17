using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Printer
{
    internal class NormalPrinter:IPrintable 
    {
        public string DocumentType { get; set; } = "pdf";
        public string NameOfPrinter{ get; set; } = "hp";

        public void Printing()
        {
            Console.WriteLine("Printer:The papaer is printing");
        }
    }
}
