using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal interface IPrintable
    {
       string DocumentType { get; set; }

        void Printing();
        
            
    
    }
}
