using System;

namespace EmployeeSalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            double basicSalary = double.Parse(Console.ReadLine());

            // Create Employee object
            Employee emp = new Employee(id, name, basicSalary);

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine(emp);

            double netSalary = emp.CalculateNetSalary();
            Console.WriteLine($"Net Salary: {netSalary}");
        }
    }
}
