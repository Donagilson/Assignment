using ConsoleAppInheritance.Model;

namespace ConsoleAppInheritance
{

    //Inheritance Ability to create a new abstractions based based on the existing abstractions.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee  Default Constructor
            Employee employee = new Employee();
            employee.EmployeeId = 1001;
            employee.EmployeeName = "Sanjay";
            employee.Salary = 1000000;

            //parent

            Console.WriteLine("employee");
            Console.WriteLine(employee.GetDetails());

            Employee employee1 = new Employee(1002, "ganga", 12345);//parameterized constructor
            Console.WriteLine(employee1.GetDetails());

            //developer
            Developer developer = new Developer(1003, "dona", 45000,"c#");
            Console.WriteLine(developer.GetDetails() +$" language:{developer.ProgrammingLanguage}");

            //parent
            employee.GetDetails();

            Console.ReadKey();
        }
    }
}
