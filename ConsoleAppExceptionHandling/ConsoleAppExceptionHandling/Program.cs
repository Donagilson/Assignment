using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                //get input from the user
                Console.WriteLine("Enter First Number");
                int firstnumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int Secondnumber = Convert.ToInt32(Console.ReadLine());

                int result = 0;
                result = firstnumber / Secondnumber;
                Console.WriteLine("Result is:" + result);
            }
            catch(DivideByZeroException exc)
            {
                Console.WriteLine(exc.Message);//inbuilt method.
                Console.WriteLine("Try again");

            }

            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            finally
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
           


        }
       
    }
}
