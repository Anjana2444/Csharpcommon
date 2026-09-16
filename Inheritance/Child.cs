using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Child:Person
    {
        public int ChildId { get; set; }

        public void ChildIdGeneration()
        {
            Console.WriteLine("Child: Id Generated Successfully");
        }
    }
}
