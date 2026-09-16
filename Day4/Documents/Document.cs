using System;
using System.Collections.Generic;
using System.Text;

namespace AllDocuments
{
    internal abstract class Document
    {
        public string FileName { get; set; }

        public abstract void DocumentLocation();
        public virtual void OpenDocument()
        {
            Console.WriteLine("Opening Document");
        }
    }
}
