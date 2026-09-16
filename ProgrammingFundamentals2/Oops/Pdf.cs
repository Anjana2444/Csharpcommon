using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Pdf:Document
    {
        public string Reusability { get; set; }

        public override void ContentOfTheFile()
        {
            Console.WriteLine("This file is a Study Material");
        }

        public override void LanguageUsedInTheFile()
        {
            base.LanguageUsedInTheFile();
            Console.WriteLine("Malayalam");
        }

        public void DisplayStatus()
        { 
            Console.WriteLine($"THIS FILE IS {this.Reusability}");
        }
       
    }
}
