using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class NormalPrinter : IPrintable
    {

        public void Print()
        {
            Console.WriteLine("Normal printer is printing");
        }
    }
}
