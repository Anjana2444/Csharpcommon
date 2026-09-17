using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    internal class Tablet:ICamera,ICallable
    {
        public void TakePhoto()
        {
            Console.WriteLine("Camera takes the photo on Tablet");
        }

        public void Call()
        {
            Console.WriteLine("Can make call on Tablet");
        }
    }
}
