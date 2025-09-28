using System;

namespace ConsoleAppQuestion6FibonnacciSeries.Utility
{
    public class Fibonnacci
    {
        // Method to print the Fibonacci series
        public static void PrintSeries(int n)
        {
            int a = 0, b = 1;

            Console.WriteLine("Fibonacci Series:");

            Console.Write(a + " ");
            Console.Write(b + " ");

            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.WriteLine(); // move to next line after printing
        }
    }
}
