using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal interface IPrintable
    {
        
        int PagesToPrint { get; set; }

        //void Print(TextWriter writer);
        void Print();
    }
}
