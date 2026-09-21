using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Tablet : ICall, ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking Photo on tablet");
        }

        public void Call()
        {
            Console.WriteLine("Calling on tablet...");
        }
    }
}
