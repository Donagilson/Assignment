using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEncapsulation.Model
{
    public class Employee
    {
        // Feilds - Data
        private int employeeid;
        private string name;
        private double salary;

        //CONSTURCTOR - default constructor
        public Employee()
        {


        }
        //parameterized constructor
        public Employee(int _employeeid,string _name,double _salary)
        {
            this.employeeid = _employeeid;
            this.name = _name;
            this.salary = _salary;
        }

        //Encapsulation - public getter(Read the value) and setter (write the value)
        public int Employeeid  // employeeid
        {
            set
            {
                if (value > 0)  // only allows positive values

                    employeeid = value;
                else
                    Console.WriteLine("Employee id must be positive");

                
            }
            
            //read 
            get
            {
                return employeeid;
            }
        }
        public string EmployeeName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty");
                }
                else
                {
                    name = value;
                }

                
                

            }
            get
            {
                return name;
            }
        }
        public double Salary
        {
            set
            {
                if(value>=10000)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("salary must be atleast 10000");
                }
                
            }
            get
            {
                return salary;
            }
        }

        public override string ToString()
        {
            return $"Employee ID: {Employeeid}, Name: {EmployeeName}, Salary: {Salary}";
        }


        //Override ToString()


    }
}
