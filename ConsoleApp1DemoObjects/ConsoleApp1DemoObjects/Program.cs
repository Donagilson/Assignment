using ConsoleApp1DemoObjects.Model;

namespace ConsoleApp1DemoObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creating an objects of a Car Class
            //new Car(); //anonymous objects
            Car maruti = new Car();

            //storing a value // we should not disclose datafeilds explicitly for that we use encapsulation
            //and the below one is wrong method
            maruti.make = "maruthi";
            maruti.year = 2000;
            maruti.color = "Red";
            maruti.StartEngine();
            maruti.StopEngine();

            Console.WriteLine(maruti);








            Console.WriteLine("Press any key to Continue.....");
            Console.ReadKey();

        }
    }
}
