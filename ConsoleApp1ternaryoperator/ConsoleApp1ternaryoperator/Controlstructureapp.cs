using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ternaryoperator
{
    internal class Controlstructureapp
    {
        static void Main(string[] args)
        {
            /*
            #region IF
            //Get input from the user ---Even or ODD
            int inputnumber = 0;

            Console.WriteLine("enter the number:");
            //inputnumber = Convert.ToInt32(Console.ReadLine());
            inputnumber = int.Parse(Console.ReadLine());

            //checking mcondition
            if (inputnumber % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd Number");

            #endregion
            */

            //Mathematical Operation
            int firstnumber = 0, secondnumber = 0;
            firstnumber = Convert.ToInt32(Console.ReadLine());
            secondnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition");

            Console.WriteLine("2.subtraction");

            Console.WriteLine("3.product");

            Console.WriteLine("4.divide");

            //get choice from the user

            Console.Write("Enter your choice(1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());

            //logic

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Sum is :" + (firstnumber + secondnumber));
                    break;
                case 2:
                    Console.WriteLine("Difference is :" + (firstnumber - secondnumber));
                    break;
                case 3:
                    Console.WriteLine("Product is :" + firstnumber * secondnumber);
                    break;
                case 4:
                    Console.WriteLine("division is :" + firstnumber / secondnumber);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;



            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();




        }
    }
}
