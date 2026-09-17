using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Tablet : ICamera, ICall
    {
        public void TakePhoto()
        {
            Console.WriteLine("Tablet Taking Photo!!!");
        }
        public void Call()
        {
            Console.WriteLine("Tablet Ringing!!!");
        }
    }
}
