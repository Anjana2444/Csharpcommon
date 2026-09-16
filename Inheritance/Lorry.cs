using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    internal class Lorry:Vehicle
    {
        public string size { get; set; }
        public void UseBreak()
        {
            Console.WriteLine("Apply break");
        }
    }
}
