namespace ConsoleAppArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (utility.numbercheck.IsArmstrong(num))
                Console.WriteLine($"{num} is an Armstrong number.");
            else
                Console.WriteLine($"{num} is NOT an Armstrong number.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
