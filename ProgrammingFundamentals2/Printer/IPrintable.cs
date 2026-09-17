using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal interface IPrintable
    {
        int Speed { get; set; }
        void Print();
    }
}
