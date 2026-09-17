using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class MultifunctionalPrinter : IScanable, IPrintable, IFaxable
    {
        public int Speed { get; set; }
        public void Fax()
        {
          Console.WriteLine("Multifunctional Printer is recieving a fax");
        }
         public void Print()
        {
            Console.WriteLine(" Multifunctional Printer is ready to print");
        }

        public void Scan()
        {
            Console.WriteLine(" Multifunctional Printer is ready to scan");
        }
    }
}
