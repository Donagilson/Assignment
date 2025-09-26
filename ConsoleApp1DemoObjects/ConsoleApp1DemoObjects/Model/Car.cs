using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1DemoObjects.Model
{
    public class Car
    {
        // static block --- static variables



        // instance block --- instance variables --- feilds

        public string make;
        public int year;
        public string color;

        // default constructors-- for imitializing an object default constructors are neccessary.

        public Car()
        {
            
        }

        // parameterized constructors

        // methods --- with return and without return type
        public void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }

        // 2-Method 
        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
        }




        // ToString() -- to get the values.
        public override string? ToString()
        {
            return $" Make:{this.make},Year:{this.year},Color:{this.color}";
        }






    }
}
