using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public void OpenDoor()
        {
            Console.WriteLine("Door is open!!");
        }
    }
}
