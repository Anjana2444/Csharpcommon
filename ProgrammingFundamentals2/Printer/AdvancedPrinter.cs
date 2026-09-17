using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class AdvancedPrinter:IPrintable, IScanable
    {
        public int Speed { get; set; }

        public int Level { get; set; }
        public void Print()
        {
            Console.WriteLine(" advanced printer is ready to print");
        }
         
        public void Scan()
        {
            Console.WriteLine(" advanced printer is ready to scan");
        }
    }
}
