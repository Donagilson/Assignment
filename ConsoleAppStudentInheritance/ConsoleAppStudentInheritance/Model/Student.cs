using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudentInheritance.Model
{
    public class Student : Person
    {//Feilds
        public int Rollno { get; set; }

        public double Marks { get; set; }

        //Default Constructors
        public Student()
        {

        }

        //parameterized constructors

        public Student(string name, int age, int rollno, double marks)
            : base(name, age)
        {
            Rollno = rollno;
            Marks = marks;

        }

        public override void Getdata()
        {
            base.Getdata();
            Console.WriteLine("Enter Rollno:");
            Rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks:");
            Marks = Convert.ToDouble(Console.ReadLine());





            if (Marks >= 90)
            {
                Console.WriteLine("A");
            }
            else if (Marks >= 80)
            {
                Console.WriteLine("B");
            }
            else if (Marks >= 70)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }
        }
        public override void Displaydata()
        {
            base.Displaydata();
            Console.WriteLine($"Rollno:{Rollno},Marks:{Marks} ");


        }
    }
}
