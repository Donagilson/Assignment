using ConsoleAppEasy225.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1Department.Model
{
    internal class Employee
    {

        public class Employe
        {


            //fields/ Properties
            public int Id { get; set; } // Auto-gherated & digits
            public string name { get; set; } // Validates employee name
            // (alphabets + single space allowed,
            // not starting with space).
            public DateTime DateOfJoin { get; set; }
            public decimal Salary { get; set; }// Should be within last 5 days public decimal Salary ( get; set; } // Accepts only digits
                                               //Object Oriented Class Model public Department Dept ( get; set; )
            public bool InService { get; set; }
            public Department Dept { get; set; }
        }

    }
}
