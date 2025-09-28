using ConsoleAppAssignments.Model;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Rectangle Details:");

        Console.Write("Enter X (Length): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter Y (Breadth): ");
        int y = int.Parse(Console.ReadLine());

        // Create Rectangle object using constructor
        Rectangle rect = new Rectangle(x, y);

        // Display result
        rect.Display();

        Console.ReadLine();
    }
}
