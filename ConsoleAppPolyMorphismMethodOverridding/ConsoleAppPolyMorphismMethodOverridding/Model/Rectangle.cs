using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismMethodOverridding.Model
{
    public class Rectangle:GeometericFigure
    {
        //feilds

        public double Length { get; set; }
        public  double Breadth { get; set; }

      

        //Accept

        public override void Accept()
        {
            NoofSides = 4;
            Console.WriteLine("Enter Length:");
            Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breath");
            Breadth = double.Parse(Console.ReadLine());


        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle-Sides:{NoofSides},Length:{Length}" +
                $"Breadth:{Breadth}");
        }

        //virtual method to calculate area
        public override double Area()
        {
            return Length*Breadth;// default no meaning full here.

        }

    }
}
