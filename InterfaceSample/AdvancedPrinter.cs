using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class AdvancedPrinter:IPrintable,IScannable
    {
        public int PagesToPrint { get; set; } = 4;

        public int PagesToScan { get; set; } = 5;

        //public AdvancedPrinter()
        //{
        //    PagesToPrint = 4;
        //    PagesToScan = 5;
            
        //}
        public void Print()
        {
            //Console.WriteLine("Enter the number of pages to print: ");
            //PagesToPrint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Advanced Printer: {PagesToPrint} pages printed successfully");
        }

        public void Scan()
        {
            //Console.WriteLine("Enter the number of pages to scan: ");
            //PagesToScan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Advanced Printer: {PagesToScan} pages scanned successfully");
        }
    }
}
