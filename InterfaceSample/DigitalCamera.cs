using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class DigitalCamera:ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Photo taken in Digital camera");
        }
    }
}
