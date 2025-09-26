using System;

namespace ConsoleApp1assignmentday1question2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //getting input from the user

            Console.Write("Enter the name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter the Roll No: ");
            int Rollno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Mark 1: ");
            double Mark1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Mark 2: ");
            double Mark2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Mark 3: ");
            double Mark3 = Convert.ToDouble(Console.ReadLine());

            //Calculating the total marks


            double total = Mark1 + Mark2 + Mark3;
            double percentage = (total / 300) * 100;

            string division;
            if (percentage >= 60)
                division = "First Division";
            else if (percentage >= 45)
                division = "Second Division";
            else if (percentage >= 33)
                division = "Third Division";
            else
                division = "Fail";

            
            Console.WriteLine("\n--- Student Result ---");
            Console.WriteLine($"Name      : {Name}");
            Console.WriteLine($"Roll No   : {Rollno}");
            Console.WriteLine($"Total     : {total}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Division  : {division}");

            Console.ReadLine(); 
        }
    }
}
