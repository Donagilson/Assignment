using System;

namespace SpaceCounterApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int spaceCount = Program.CountSpaces(str);

            Console.WriteLine($"The number of spaces in the string is: {spaceCount}");
        }
    }
}
