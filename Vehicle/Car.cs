using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal class Car : Vehicles
    {
        public int NumberOfDoors { get; set; }
        public void OpenDoor()
        {
            Console.WriteLine("Open door");
        }
    }
}
