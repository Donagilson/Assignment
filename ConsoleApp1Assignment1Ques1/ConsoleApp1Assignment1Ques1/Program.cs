using System;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            utility.inventory.Login();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
