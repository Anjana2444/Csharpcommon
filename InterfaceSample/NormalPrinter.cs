using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class NormalPrinter:IPrintable
    {
        //public NormalPrinter()
        //{
        //    PagesToPrint = 6;

        //}
        public int PagesToPrint { get; set; } = 6;
        public void Print() 
        {
            //Console.WriteLine("Enter the number of pages to print: ");
            //PagesToPrint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Normal Printer: {PagesToPrint} pages printed successfully");
        }
    }
}
