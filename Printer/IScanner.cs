using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal interface IScanner
    {
        public int NumberOfPages { get; set; }
        void Scanable();
    }
}
