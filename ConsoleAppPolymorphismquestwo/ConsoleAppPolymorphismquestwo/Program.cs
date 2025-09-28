using ConsoleAppAssignments.Model;

class Program
{
    static void Main(string[] args)
    {
        IMathOperations math = new MathClass();

        Console.WriteLine("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Addition: {math.Add(num1, num2)}");
        Console.WriteLine($"Subtraction: {math.Subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {math.Multiply(num1, num2)}");

        try
        {
            Console.WriteLine($"Division: {math.Divide(num1, num2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}
