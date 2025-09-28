using System;

namespace DigitRecApp
{
    public class NumberModel
    {
        // Recursive method to display digits
        public void DisplayDigits(int number)
        {
            if (number == 0)
                return;

            DisplayDigits(number / 10);   // recursive call
            Console.Write(number % 10 + " "); // print last digit
        }
    }
}
