using System;

namespace ConsoleAppDivisibleBy9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Numbers between 100 and 200 divisible by 9:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(); // new line at end
        }
    }
}
