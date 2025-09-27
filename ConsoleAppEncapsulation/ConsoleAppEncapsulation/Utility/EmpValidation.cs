using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEncapsulation.Utility
{
    public class EmpValidation
    {
        //Employee Id
        public static int GetValidEmployeeId()
        {
            while (true)
            {
                Console.WriteLine("Enter Employee ID");
                if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
                    return id;
                Console.WriteLine("Invalid Entry... Try again");
                

               

            }
           

        }
        public static string GetEmployeename()
        {
            while (true)
            {
                Console.WriteLine("Enter the employee name");
                string name = Console.ReadLine();

                //check
                if(!string.IsNullOrWhiteSpace(name))
                {
                    return name;

                }
                else
                {
                    Console.WriteLine("Name cannot be empty.Please try again....");
                }

            }
            

        }
        public static double Getemployeesalary()
        {
            while (true)
            {
                Console.WriteLine("Enter  salary");
                if(double.TryParse(Console.ReadLine(),out double salary) && salary>0)
                {
                    return salary;
                }
                else
                {
                    Console.WriteLine("Salary must be 10000....Try again");
                }

            }
           
          
          

        }
    }
}
