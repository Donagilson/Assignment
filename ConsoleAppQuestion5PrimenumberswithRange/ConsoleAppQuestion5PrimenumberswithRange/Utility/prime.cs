using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleAppQuestion4Prime.Utility
{
    public static class PrimeUtility
    {
        public static void Prime()
        {
            Console.WriteLine("Enter the Range (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers up to " + n + " are:");

            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

