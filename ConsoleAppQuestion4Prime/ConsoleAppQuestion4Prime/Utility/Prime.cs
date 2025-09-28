using System;

namespace ConsoleAppQuestion4Prime.Utility
{
    public static class PrimeUtility
    {
        public static void Prime()
        {
            Console.WriteLine("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine(n + " is Prime");
            else
                Console.WriteLine(n + " is Not Prime");
        }
    }
}



























