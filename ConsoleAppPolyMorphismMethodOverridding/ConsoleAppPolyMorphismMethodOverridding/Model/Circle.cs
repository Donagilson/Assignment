using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismMethodOverridding.Model
{
    public class Circle:GeometericFigure
    {
        //feilds
        public double Radius { get; set; }
        public override void Accept()
        {
            NoofSides = 0;
            Console.WriteLine("Enter radius");
            Radius = double.Parse(Console.ReadLine());

        }

        //Virtual method to display

        public override void Display()
        {
            Console.WriteLine($"Circle - sides:{NoofSides},Radius:{Radius}");

        }

        //virtual method to calculate area
        public override double Area()
        {
            return Math.PI * Radius * Radius;


        }
    }
}
