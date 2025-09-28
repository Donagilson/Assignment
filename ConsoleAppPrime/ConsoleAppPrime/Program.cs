using System;

namespace PrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            NumberModel model = new NumberModel();

            if (model.IsPrime(num))
                Console.WriteLine($"{num} is a Prime number.");
            else
                Console.WriteLine($"{num} is NOT a Prime number.");
        }
    }
}
