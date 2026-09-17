using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Phone : ICall, ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Phone Taking Photo!!!");
        }
        public void Call()
        {
            Console.WriteLine("Phone Ringing!!!");
        }
    }
}
