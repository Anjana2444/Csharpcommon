using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class AdvancedPrinter:IPrintable,IScannable
    {
        public string DocumentType { get; set; } = "json";
        public void Printing()
        {
            Console.WriteLine("AdvancedPrinter:This takes colour print");
        }
        public int NoOfPages { get; set; } = 10 ;
         public void Scanner()
        {
            Console.WriteLine("AdvancedPrinter:The Scanner scans both side at the same type");
        }

    }
}
