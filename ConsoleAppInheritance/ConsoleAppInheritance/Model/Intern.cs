using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance.Model
{
    public class Intern : Employee
    {
        public int DurationMonths { get; set; }

        //ctor c
        public Intern(int employeeId, string name, double salary, int duration)
            : base(employeeId, name, salary)
        {
            DurationMonths = duration;
        }
        
    }
}
