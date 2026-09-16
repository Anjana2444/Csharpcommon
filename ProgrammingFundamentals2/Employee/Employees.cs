using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employee
{
    public class Employees
    {
       public int id;
       public required string Name { get; set; }
       public char team;
    }

}
