using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Phone:ICamera ,ICallable
    {
        public void TakePhoto()
        {
            Console.WriteLine("Camera takes the photo");
        }

        public void Call()
        {
            Console.WriteLine("Can make call");
        }


    }
}
