using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Tablet : ICall,ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Tablet camera quality is low");
        }
        public void TakeCall()
        {
            Console.WriteLine("Can Take calls in tablet");
        }
    }
}
