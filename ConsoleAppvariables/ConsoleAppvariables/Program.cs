namespace ConsoleAppvariables
{
    internal class Program
    {

        //entry point
        //Write a C# Sharp program that takes distance and time
//as input and displays the speed in kilometers per hour
//and miles per hour.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance (in kilometer):");
            double distancekm = Convert.ToDouble(Console.ReadLine());

            //Input time in hours
            Console.Write("Enter time (in hours):");
            double timehours = Convert.ToDouble(Console.ReadLine());

            //calculate spped in km/hr
            double speedKmPerHour = distancekm / timehours;

            //convert km to miles(1km =0.621371 miles)
            double distancemiles = distancekm * 0.621371;
            double speedMilesPerHour = distancemiles / timehours;

            displayoutput(speedKmPerHour, speedMilesPerHour);

            //Display to call method

            Console.WriteLine("press the key to continue");
            Console.ReadKey();



        }
        #region display output void accept argument
        private static void displayoutput(double kmperhour,double milesperhr)
        {
            //display the result
            Console.WriteLine("Speed Results:");
            Console.WriteLine("Speed in km/hr:" +kmperhour);
            Console.WriteLine("Speed in mp/hr:" +milesperhr);

        }
        #endregion
    }
}
