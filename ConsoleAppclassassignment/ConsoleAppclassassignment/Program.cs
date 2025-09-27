namespace ConsoleAppclassassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetInput();

        }
        private static void GetInput()
        {
            Console.WriteLine("Enter distance in km");
            double distance = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter distance in km");
            double fuelefficiency = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter distance in km");
            double fuelprice = Convert.ToDouble(Console.ReadLine());

        }
        
    }
}
