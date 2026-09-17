using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal interface IScannable
    {
         int NoOfPages { get; set; }

        void Scanner();
    }
}
