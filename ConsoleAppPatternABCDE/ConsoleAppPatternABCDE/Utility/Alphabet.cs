using System;

namespace ConsoleAppAlphabetPattern
{
    public class AlphabetPattern
    {
        public static void PrintPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Print increasing part (A, B, C...)
                for (int j = 0; j < i; j++)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                // Print decreasing part (back to A)
                for (int j = i - 2; j >= 0; j--)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
