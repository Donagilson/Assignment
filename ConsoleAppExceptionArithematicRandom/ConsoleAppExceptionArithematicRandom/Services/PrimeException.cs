using System;

namespace ConsoleAppExceptionArithmetic.Services
{
    public class PrimeException : Exception
    {
        public PrimeException(int number)
            : base($"Prime number detected: {number}")
        {
        }
    }
}
