using System;
using System.Collections.Generic;
using System.Text;

namespace Documentation
{
    internal class WordDocument : Document
    {
        public override void Options()
        {
            base.Options();
            Console.WriteLine("Child: Write Mode");
        }
        public override void NumberOfPages()
        {
            Console.WriteLine("Pages: 2");
        }
    }
}
