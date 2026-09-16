using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal abstract class Document
    {
        public string FileName { get; set; }

        public abstract void ContentOfTheFile();

        public virtual void LanguageUsedInTheFile()
        {
            Console.WriteLine("Document Language is:");
        }

        public void NumberOfWords()
        {
            Console.WriteLine("This document have 10000 Words");
        }

        public void DisplayName()
        {
            Console.WriteLine($"The Name of file: {this.FileName}");
        }
    }
}
