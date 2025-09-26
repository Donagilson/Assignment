using System;

namespace CoordinateQuadrantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            utility.QuadrantChecker.CheckQuadrant();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
