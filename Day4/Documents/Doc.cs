using System;
using System.Collections.Generic;
using System.Text;

namespace AllDocuments
{
    internal class Doc : Document
    {
        public override void DocumentLocation()
        {
            Console.WriteLine("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\10.0.12");
        }
        public override void OpenDocument()
        {
            base.OpenDocument();
            Console.WriteLine("Doc Opened!!");
        }
    }
}
