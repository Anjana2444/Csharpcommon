using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Person
    {
        public int HouseNo { get; set; }

        public void PlaceOfOrigin()
        {
            Console.WriteLine("PLACE: Keralam, Ernakulam,Tripunithura, Puthiyakavu");
        }

        public void DisplayHouseNo()
        {
            Console.WriteLine($"The house number is {this.HouseNo}");
        }
    }
}











