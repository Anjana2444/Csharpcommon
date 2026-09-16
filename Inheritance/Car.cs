using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class Car:Vehicle
    {
        public int NumberOfDoor { get; set; }
        public void OpenDoor()
        {
            Console.WriteLine("open door");
        }
    }
}
