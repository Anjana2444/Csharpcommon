using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class MultifunctionPrinter : IPrintable, IScanner, IFaxable
    {
        public string DocumentType { get; set; }
        public int NumberOfPages { get; set; }
        public int MachineNumber { get; set; }

        public void Faxable()
        {
            Console.WriteLine($"Machine Number: {this.MachineNumber}");
            Console.WriteLine("Multifunction Printer is able fax easily.");
        }

        public void Printable()
        {
            Console.WriteLine($"Docuemnt Type: {this.DocumentType}");
            Console.WriteLine("Multifunction Printer is Printable (Fastest).");
        }

        public void Scanable()
        {
            Console.WriteLine($"Number of pages to scan: {this.NumberOfPages}");
            Console.WriteLine("Multifunction Printer is able to scan both sides faster.");
        }
    }
}
