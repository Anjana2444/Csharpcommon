using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal abstract class Document
    {
        public int DocumentId { get; set; }

        public virtual void Read() 
        {
            Console.WriteLine("Parent : Document read Successfully");
        }

        public abstract void Write();


    }
}
