using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Phone : ICall, ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking Photo on Phone");
        }

        public void Call()
        {
            Console.WriteLine("Calling on Phone...");
        }
    }
}
