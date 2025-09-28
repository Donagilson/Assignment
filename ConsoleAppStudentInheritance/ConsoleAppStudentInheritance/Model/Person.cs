using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudentInheritance.Model
{
    public class Person
    {

        //feilds
        public string Name { get; set; }

        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        // method
        public virtual void Getdata()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
        }

        public virtual  void Displaydata()
        {
            Console.WriteLine($"Name:{Name},Age:{Age}");
        }
        
    }
}
