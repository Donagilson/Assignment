using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance.Model
{
    // Base Employee
    public class Employee
    {
        public int EmployeeId { get; set; }
        public  string EmployeeName { get; set; }

        public double Salary { get; set; }

        //default constructor
        public Employee()
        {

        }

        //parameterized constructor

        public Employee(int employeeId,string employeeName,double salary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Salary = salary;

        }

        //get details of the employee

        public string GetDetails()
        {
            // return $"ID: {EmployeeId},Name:{EmployeeName},Salary:{Salary}";
            StringBuilder sb = new StringBuilder();
            sb.Append("Id: ").Append(EmployeeId)
                .Append("Name: ").Append(EmployeeName)
                .Append("Salary: ").Append(Salary);
            return sb.ToString();

        }

    }
}
