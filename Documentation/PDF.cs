using System;
using System.Collections.Generic;
using System.Text;

namespace Documentation
{
    internal class PDF : Document
    {
        public override void NumberOfPages()
        {
            Console.WriteLine("Pages: 5");
        }
    }
}
