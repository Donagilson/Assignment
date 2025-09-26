namespace ConsoleApp1Assingment2question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maths mark");
            double maths = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Mark of Physics");
            double phy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Mark for Chemistry");
            double chem = Convert.ToDouble(Console.ReadLine());

            double Totalmark = maths + phy + chem;
            double mark = phy + maths;


            if (maths >= 65 && phy >= 55 && chem >= 50 && Totalmark >= 180 || mark >= 140)
                Console.WriteLine("Eligible for Admission");

            else
                Console.WriteLine("Not Eligible for Admission");
                

            



        }
    }
}
