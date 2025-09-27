namespace ConsoleAppAssignment3PatternDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for half the diamond: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Call the method from utility to print the diamond
            utility.pattern.PrintDiamond(n);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
