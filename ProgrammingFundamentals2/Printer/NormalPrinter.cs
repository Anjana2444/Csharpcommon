using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class NormalPrinter: IPrintable
    {
        public int Speed {  get; set; }
        public void Print()
        {
            Console.WriteLine("The Machine is ready to print");
        }

    }
}
