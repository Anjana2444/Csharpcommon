using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class DigitalCamera: ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking Photo on digital camera");
        }
    }
}
