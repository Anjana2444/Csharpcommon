using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class NormalPrinter : IPrintable, IScanner
    {
        public string DocumentType { get; set; }
        public int NumberOfPages { get; set; }

        public void Printable()
        {
            Console.WriteLine($"Docuemnt Type: {this.DocumentType}");
            Console.WriteLine("Normal Printer is Printable (Slow).");
        }

        public void Scanable()
        {
            Console.WriteLine($"Number of pages to scan: {this.NumberOfPages}");
            Console.WriteLine("Normal Printer is able to scan one side only.");
        }
    }
}
