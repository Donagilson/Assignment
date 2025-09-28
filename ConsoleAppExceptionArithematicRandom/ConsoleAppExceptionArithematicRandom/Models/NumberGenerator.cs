using System;

namespace ConsoleAppExceptionArithmetic.Models
{
    public class NumberGenerator
    {
        private static readonly Random _random = new Random();

        // Generate random number within user-given range
        public int GenerateRandomNumber(int min, int max)
        {
            return _random.Next(min, max + 1); // inclusive of max
        }
    }
}
