using System;

namespace ConsoleAppPrintStrongNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;     // keep original number
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;   // extract last digit
                sum += Factorial(digit); // add factorial of digit
                n = n / 10;          // remove last digit
            }

            if (sum == temp)
                Console.WriteLine(temp + " is a Strong Number.");
            else
                Console.WriteLine(temp + " is NOT a Strong Number.");
        }

        // Method to calculate factorial
        static int Factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
