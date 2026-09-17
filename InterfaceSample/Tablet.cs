using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Tablet : ICamera, ICall
    {
        public void Call()
        {
            Console.WriteLine("Tablet: Call completed.");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Tablet: Photo taken.");
        }
    }
}
