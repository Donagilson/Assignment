using ConsoleAppAssignments.Model;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose Shape: 1=Cube, 2=Sphere, 3=Cylinder, 4=Cone");
        int choice = int.Parse(Console.ReadLine());

        Shape shape = null;

        switch (choice)
        {
            case 1:
                Console.Write("Enter side length of Cube: ");
                double side = double.Parse(Console.ReadLine());
                shape = new Cube(side);
                break;

            case 2:
                Console.Write("Enter radius of Sphere: ");
                double radiusS = double.Parse(Console.ReadLine());
                shape = new Sphere(radiusS);
                break;

            case 3:
                Console.Write("Enter radius of Cylinder: ");
                double radiusC = double.Parse(Console.ReadLine());
                Console.Write("Enter height of Cylinder: ");
                double heightC = double.Parse(Console.ReadLine());
                shape = new Cylinder(radiusC, heightC);
                break;

            case 4:
                Console.Write("Enter radius of Cone: ");
                double radiusCone = double.Parse(Console.ReadLine());
                Console.Write("Enter height of Cone: ");
                double heightCone = double.Parse(Console.ReadLine());
                shape = new Cone(radiusCone, heightCone);
                break;

            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        Console.WriteLine($"\nArea = {shape.GetArea():F2}");
        Console.WriteLine($"Volume = {shape.GetVolume():F2}");

        Console.ReadLine();
    }
}
