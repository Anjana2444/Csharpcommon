using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Excel:Document
    {
        public string ExcelName { get; set; }

        public override void Read()
        {
            Console.WriteLine("Excel : Document read Successfully");
        }

        public override void Write()
        {
            Console.WriteLine("Excel: Document wrote successfully");
        }
    }
}
