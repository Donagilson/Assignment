using System;
using ConsoleAppQuestion6FibonnacciSeries.Utility;

namespace ConsoleAppQuestion6FibonnacciSeries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Call the method from Utility class
            Fibonnacci.PrintSeries(n);
        }
    }
}
