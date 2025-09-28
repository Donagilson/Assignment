using System;

namespace DigitApp
{
    public class NumberModel
    {
        // Method to calculate sum of digits
        public int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;  // extract last digit
                sum += digit;
                number /= 10;             // remove last digit
            }
            return sum;
        }
    }
}
