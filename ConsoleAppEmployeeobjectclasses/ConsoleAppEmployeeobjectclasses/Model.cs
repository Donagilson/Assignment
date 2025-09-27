using System;

namespace EmployeeSalaryApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }

        public Employee(int id, string name, double basicSalary)
        {
            Id = id;
            Name = name;
            BasicSalary = basicSalary;
        }

        // Method to calculate salary with some allowance + deduction
        public double CalculateNetSalary()
        {
            double hra = BasicSalary * 0.20;   // 20% HRA
            double da = BasicSalary * 0.10;    // 10% DA
            double pf = BasicSalary * 0.05;    // 5% PF deduction

            return BasicSalary + hra + da - pf;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Basic Salary: {BasicSalary}";
        }
    }
}
