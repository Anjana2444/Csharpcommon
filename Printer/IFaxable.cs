using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal interface IFaxable
    {
         int MachineId { get; set; }
        void FaxSend();

    }
}
