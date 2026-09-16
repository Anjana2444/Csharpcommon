using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Lorry : Vehicle
    {
        public int Size { get; set; }
        public void UseBreak()
        {
            Console.WriteLine("Apply Breaks!!");
        }
    }
}
