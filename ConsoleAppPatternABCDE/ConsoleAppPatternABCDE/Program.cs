using System;

namespace ConsoleAppAlphabetPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            AlphabetPattern.PrintPattern(n);
        }
    }
}
