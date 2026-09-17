using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class AdvancePrinter : IPrintable, IScanner
    {
        public string DocumentType { get; set; }
        public int NumberOfPages { get; set; }

        public void Printable()
        {
            Console.WriteLine($"Docuemnt Type: {this.DocumentType}");
            Console.WriteLine("Advance Printer is Printable (Fast).");
        }

        public void Scanable()
        {
            Console.WriteLine($"Number of pages to scan: {this.NumberOfPages}");
            Console.WriteLine("Advance Printer is able to scan both sides at the same time.");
        }
    }
}
