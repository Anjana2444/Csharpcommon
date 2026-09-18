using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class AdvancedPrinter : IPrintable,IScanner,IFaxable
    {

        public void Print()
        {
            Console.WriteLine("Advanced printer is printing");
        }
        public void Scan()
        {
            Console.WriteLine("Advanced printer is scanning");
        }
        public void Fax()
        {
            Console.WriteLine("Advanced printer is sending fax");
        }
        public void PrintInColor()
        {
            Console.WriteLine("Advanced printer is printing colour copies");
        }
    }
}
