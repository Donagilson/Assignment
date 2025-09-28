using System;
using System.IO;

namespace ConsoleAppFileHandling
{
    public class LogFileCreation
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a value: ");
                int firstnumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int secnumber = Convert.ToInt32(Console.ReadLine());

                int result = firstnumber / secnumber;
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! See the log file for more details.");

                string location = "logerror.txt";

                // Always append or create new if file not exists
                using (StreamWriter sw = new StreamWriter(location, true))
                {
                    sw.WriteLine($"{DateTime.Now} | {ex.Message}");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
