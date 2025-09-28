using System;

namespace FibonacciApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many terms of Fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Sequence:");
            Program.Fibonacci(n);
        }
    }
}
