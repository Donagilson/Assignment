namespace ConsoleApp1assign_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input distance in km
            Console.WriteLine("Enter the distance in Km:");
            double distance = Convert.ToDouble(Console.ReadLine());

            //Input fuel in liters
            Console.WriteLine("Enter Fuel consumed in liters:");
            double fuel = Convert.ToDouble(Console.ReadLine());

            //Calculating the fuel efficiency
            double efficiency = distance / fuel;

            //convert the result into gallon
            double gallon = efficiency * 235.215;
            displayout(efficiency, gallon);

        }

        #region
        private static void displayout(double eff,double gallon)
        {
            //display the output
            Console.WriteLine("Result:");
            Console.WriteLine("efficiency:" + eff);
            Console.WriteLine("gallon:" + gallon);
        }
        #endregion

    }
}
