using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Text:Document
    {
        public string Reusabilitys { get; set; }

        public override void ContentOfTheFile()
        {
            Console.WriteLine("This file is a Reference Material");
        }

        public override void LanguageUsedInTheFile()
        {
            base.LanguageUsedInTheFile();
            Console.WriteLine("Sanskrit");
        }

        public void DisplayofStatus()
        {
            Console.WriteLine($"THIS FILE IS {this.Reusabilitys}");
        }
    }
}
