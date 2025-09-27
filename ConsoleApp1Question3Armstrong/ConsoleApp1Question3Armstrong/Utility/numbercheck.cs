using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utility
{
    public static class numbercheck
    {
        public static bool IsArmstrong(int num)
        {
            if (num < 0)
                return false; // Armstrong numbers are non-negative

            int sum = 0;
            int temp = num;

            // Count digits
            int digits = num.ToString().Length;

            // Calculate sum of digits raised to the power of digits
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            return sum == num;
        }
    }
}

