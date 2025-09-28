using ConsoleAppExceptionArithmetic.Services;
using System;

namespace ConsoleAppExceptionArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minimum range: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter maximum range: ");
            int max = Convert.ToInt32(Console.ReadLine());

            RandomNumberService service = new RandomNumberService();

            try
            {
                int randomNum = service.GetRandomNumber(min, max);
                Console.WriteLine($"Generated Number: {randomNum}");
            }
            catch (PrimeException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            Console.WriteLine("Program finished.");
        }
    }
}
