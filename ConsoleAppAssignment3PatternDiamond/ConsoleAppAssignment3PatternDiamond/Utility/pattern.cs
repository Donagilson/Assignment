using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utility
{
    public static class pattern
    {
        public static void PrintDiamond(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Number must be greater than zero.");
                return;
            }
            //for printing the first half
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");

                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }
            //for bottom half
            
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                    Console.Write(" ");

                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}

