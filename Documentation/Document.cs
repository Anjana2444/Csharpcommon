using System;
using System.Collections.Generic;
using System.Text;

namespace Documentation
{
    internal abstract class Document
    {
        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        public virtual void Options()
        {
            Console.WriteLine("Parent: Read Mode");
        }
        public abstract void NumberOfPages();
    }
}
