using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class MultiFunctionPrinter : IPrintable, IScannable, IFaxable
    {
        public int PagesToPrint { get; set; } = 1;

        public int PagesToScan { get; set; } = 2;

        public int PagesToFax { get; set; } = 3;

        //public MultiFunctionPrinter()
        //{ 
        //    PagesToPrint = 1;
        //    PagesToScan = 2;
        //    PagesToFax = 3;
        //}
        public void Print()
        {
            //Console.WriteLine("Enter the number of pages to print: ");
            //PagesToPrint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multifunctional Printer: {PagesToPrint} pages printed successfully");
        }

        public void Scan()
        {
            //Console.WriteLine("Enter the number of pages to scan: ");
            //PagesToScan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multifunctional Printer: {PagesToScan} pages scanned successfully");
        }

        public void Fax()
        {
            //Console.WriteLine("Enter the number of pages to scan");
            //PagesToFax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multifunctional Printer: {PagesToFax} pages faxed successfully");
        }

    }
}
