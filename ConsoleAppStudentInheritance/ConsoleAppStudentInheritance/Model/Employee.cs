using ConsoleAppStudentInheritance.Model;

class Employee : Person
{
    public double BP { get; set; } // Basic Pay
    public double HR { get; set; } // House Rent
    public double Sal { get; set; } // Salary

    public void Get_data()
    {
        base.Getdata();

        Console.Write("Enter Basic Pay: ");
        BP = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter House Rent Allowance: ");
        HR = Convert.ToDouble(Console.ReadLine());
    }

    public void Compute_salary()
    {
        Sal = BP + HR;
    }

    public void Show_data()
    {
        base.Displaydata();
        Compute_salary();
        Console.WriteLine($"Basic Pay: {BP}, HR: {HR}, Salary: {Sal}");
    }
}

