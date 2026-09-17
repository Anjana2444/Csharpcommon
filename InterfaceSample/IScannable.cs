using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal interface IScannable
    {
        int PagesToScan { get; set; }
        void Scan();
    }
}
