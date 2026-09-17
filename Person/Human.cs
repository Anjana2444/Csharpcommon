using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    internal class Human
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Name{ get; set; }
        public void GetIntroduction(string name, string gender, int age, string designation)
        {
            Console.WriteLine($"Hi My name is {name} ({gender}).\nI am {age} years old.\nMy designation is {designation}.");
        }
    }
}
