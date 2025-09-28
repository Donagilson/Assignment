using System;
using System.Collections.Generic;
using EmployeeApp.Models;

namespace EmployeeApp.Services
{
    public class EmployeeService
    {
        private readonly List<Employee> employees = new List<Employee>();

        public void AddEmployee(int id, string name, int age)
        {
            if (age < 18 || age > 60)
            {
                throw new InvalidAgeException("Employee age must be between 18 and 60.");
            }

            Employee emp = new Employee(id, name, age);
            employees.Add(emp);
            Console.WriteLine("Employee added successfully!");
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("\n--- Employee List ---");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
