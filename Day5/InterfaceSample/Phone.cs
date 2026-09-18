using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Phone : ICall , ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Phone camera quality is low");
        }
        public void TakeCall()
        {
            Console.WriteLine("Can Take calls in phone");
        }
    }
}
