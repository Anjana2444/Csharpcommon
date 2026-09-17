using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    internal class Employee:Students
    {
        public String EmpName{ get; set; }
        public string CompanyName { get; set; }

        public void GoingToOffice()
        {
            Console.WriteLine($"{EmpName} is going to  {CompanyName}");
        }
    }
}
