using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public void IsAlive()
        {
            Console.WriteLine("This person is Alive");
        }
    }
}
