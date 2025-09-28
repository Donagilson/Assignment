using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance.Model
{
    public class Developer : Employee
    {
        //Fields
        public string ProgrammingLanguage { get; set; }

        //Constructor
        public Developer(int employeeId, string name, double salary, string progLang)
            : base(employeeId, name, salary)
        {
            ProgrammingLanguage = progLang;
        }
    }
}