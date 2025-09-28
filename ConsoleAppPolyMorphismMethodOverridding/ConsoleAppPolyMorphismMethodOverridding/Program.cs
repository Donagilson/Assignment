using ConsoleAppPolyMorphismMethodOverridding.Model;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppPolyMorphismMethodOverridding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choicecontinue = "yes";
            while (choicecontinue== "yes")
                {



                //Create null objects of base
                GeometericFigure figure = null;



                //Get input from the user for choosing shape

                //based on the shape option calculate area and display.
                Console.WriteLine("Choose a shape(\n1.Rectangle\n2.Square\n3.Circle");


                int choice = int.Parse(Console.ReadLine());





                //create respective shape object and invoke methods

                switch (choice)
                {
                    case 1:
                        figure = new Rectangle();
                        break;
                    //Square
                    case 2:
                        figure = new Square();
                        break;

                    //Circle
                    case 3:
                        figure = new Circle();
                        break;

                    //default
                    default:
                        Console.WriteLine("Invalid");
                        return;


                }



                figure.Accept();
                figure.Display();
                Console.WriteLine($"Area={figure.Area():F2}");

                Console.Write("\nDo you want to continue? (yes/no): ");
                choicecontinue = Console.ReadLine().ToLower();

                }
                Console.ReadKey();
            
        }
    }
}
