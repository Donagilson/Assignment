using ConsoleAppEncapsulation.Model;
using ConsoleAppEncapsulation.Utility;

namespace ConsoleAppEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Employeeid = EmpValidation.GetValidEmployeeId();
            employee.EmployeeName = EmpValidation.GetEmployeename();
            employee.Salary = EmpValidation.Getemployeesalary();

            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine(employee); // calls ToString()
        }
    }
}
