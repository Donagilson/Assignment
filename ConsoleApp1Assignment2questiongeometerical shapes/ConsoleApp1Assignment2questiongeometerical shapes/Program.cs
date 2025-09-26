using System;
using System.Xml.Serialization;

namespace ConsoleApp1Assignment2questiongeometerical_shapes
{
    internal class Program
    {
        static void Main(string[] args)

        
        {
            char continuechoice = 'n';
            do
            {
                //Area Calculating
                Console.WriteLine("1.Area of the circle:");
                Console.WriteLine("2.Area of Triangle:");
                Console.WriteLine("3.Area of rectangle:");
                Console.WriteLine("4.Exit:");
                Console.WriteLine("choose the option(1-4):");

                //getting the choice from the user
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the radius");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        double area = 3.14 * radius * radius;
                        Console.WriteLine($"Area of Circle = {area:F2}");

                        break;
                    case 2:
                        Console.WriteLine("Enter the length:");
                        Console.WriteLine("Enter the breadth:");
                        double length = Convert.ToDouble(Console.ReadLine());
                        double breadth = Convert.ToDouble(Console.ReadLine());
                        double area1 = 0.5 * length * breadth;
                        Console.WriteLine($"Area of Triangle = {area1:F2}");
                        break;

                    case 3:
                        Console.WriteLine("Enter the side");
                        double side = Convert.ToDouble(Console.ReadLine());
                        double area2 = side * side;
                        Console.WriteLine($"Area of Rectangle = {area2:F2}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting the program");
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program");
                        break;




                }
            } while(continuechoice == 'y');

                
            
                
        }
        


    }
}
