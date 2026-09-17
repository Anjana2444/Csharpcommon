using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class DigitalCamera: ICamera
    {
    

        public void TakePhoto()
        {
            Console.WriteLine("Digital Camera: Photo taken.");
        }   
    }
}
