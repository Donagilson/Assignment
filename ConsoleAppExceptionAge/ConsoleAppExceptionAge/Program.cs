using System;
using EmployeeApp.Services;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService();

            try
            {
                Console.Write("Enter Employee ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee Age: ");
                int age = int.Parse(Console.ReadLine());

                service.AddEmployee(id, name, age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }

            service.DisplayEmployees();
        }
    }
}
