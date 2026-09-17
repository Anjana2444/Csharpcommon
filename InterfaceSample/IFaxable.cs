using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal interface IFaxable
    {
        int PagesToFax { get; set; }
        void Fax();
    }
}
