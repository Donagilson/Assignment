namespace ConsoleAppCarEfficiency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetuserInput();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static void GetuserInput()
        {
            // Distance Travelled
            Console.Write("Enter distance travelled (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Fuel consumption
            Console.Write("Enter fuel consumed (liters): ");
            double fuel = Convert.ToDouble(Console.ReadLine());

            // Call method for L/100km
            double lper100km = utility.efficiency.CalculateLitersPer100km(distance, fuel);

            // Call method for MPG
            double mpg = utility.efficiency.Converttompg(lper100km);

            // Output the result
            Console.WriteLine($"\nFuel efficiency: {lper100km:F2} L/100km");
            Console.WriteLine($"Equivalent: {mpg:F2} MPG");
        }
    }
}
