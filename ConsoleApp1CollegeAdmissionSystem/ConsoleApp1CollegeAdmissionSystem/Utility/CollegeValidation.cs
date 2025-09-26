using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCLGAdmission.Utility
{
    public class CLGVaildation
    {
        public class CLGVaildation
        {
            //Fields -data--(Data hiding)
            private int StudentId;
            private string Name;
            private double Marks;

            //Constructor -same name of class
            //Default Constructor
            public CLGVaildation()
            {

            }
            //Parametrized constructor
            public CLGVaildation(int _StudentId, string _Name, double _Marks)
            {
                this.StudentId = _StudentId;
                this.Name = _Name;
                this.Marks = _Marks;
            }

        }
        public class CLGVaildation
        {
            //StudentId
            public static int GetValidStudentId()
            {
                while (true)
                {
                    Console.Write("Enter the Student Id: ");
                    if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
                        return id;
                    Console.WriteLine("Invalid Entry...Try Again");

                }
            }

            public static string GetValidName()
            {
                while (true)
                {

                }
            }
        }




    }