using ConsoleAppEms2025.Model;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Employee Details:");
        Console.Write("EmpNo: ");
        int empNo = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Designation: ");
        string designation = Console.ReadLine();

        Console.Write("Basic Pay: ");
        double basicPay = double.Parse(Console.ReadLine());

        if (basicPay > 10000)
        {
            Executive exec = new Executive(empNo, name, designation, basicPay);
            exec.Display();
        }
        else
        {
            Employee emp = new Employee(empNo, name, designation, basicPay);
            emp.Display();
        }

        Console.ReadLine();
    }
}
