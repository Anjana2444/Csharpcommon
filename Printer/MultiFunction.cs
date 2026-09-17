using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class MultiFunction:IFaxable
    {
        public int MachineId { get; set; } = 101;
        public void FaxSend()
        {
            Console.WriteLine("MultiFunction: does all the tasks");
        }
    }
}
