using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class MultiFunctionPrinter : IFaxable,IPrintable,IScanner
    {
        public void Print()
        {
            Console.WriteLine("Multifunction Printer is printing");
        }
        public void Scan()
        {
            Console.WriteLine("Multifunction Printer is scanning ");
        }
        public void Fax()
        {
            Console.WriteLine("Multifunction printer is sending fax");
        }
    }
}
