using ConsoleAppExceptionArithmetic.Models;
using System;

namespace ConsoleAppExceptionArithmetic.Services
{
    public class RandomNumberService
    {
        private readonly NumberGenerator _generator = new NumberGenerator();

        // Method: Generate random number in user range
        public int GetRandomNumber(int min, int max)
        {
            int number = _generator.GenerateRandomNumber(min, max);

            if (IsPrime(number))
            {
                throw new PrimeException(number);
            }

            return number;
        }

        // Check if number is prime
        private bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
