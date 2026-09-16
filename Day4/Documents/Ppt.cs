using System;
using System.Collections.Generic;
using System.Text;

namespace AllDocuments
{
    internal class Ppt : Document
    {
        public override void DocumentLocation()
        {
            Console.WriteLine("C:\\Program Files\\dotnet\\");
        }
        public override void OpenDocument()
        {
            base.OpenDocument();
            Console.WriteLine("Ppt Opened!!");
        }
    }
}
