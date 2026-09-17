using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{ 
    internal class Phone : ICamera,ICall
    {
        public void TakePhoto() 
        {
            Console.WriteLine("Phone: Photo taken.");
        }

        public void Call()
        {
            Console.WriteLine("Phone: Call completed.");
        }
    }
}
