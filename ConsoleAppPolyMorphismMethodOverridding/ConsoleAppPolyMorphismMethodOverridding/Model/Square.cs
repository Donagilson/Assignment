using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismMethodOverridding.Model
{

    //ability to implement inherited propertise or methods in different ways across multiple abstractions
    public class Square : GeometericFigure
    {
        public double side { get; set; }
        //method to accept sides

        public override void Accept()
        {
            NoofSides = 4;
            Console.WriteLine("Enter side");
            side = double.Parse(Console.ReadLine());
            
        }

        //Virtual method to display

        public override void Display()
        {
            Console.WriteLine($"Square - sides:{NoofSides},Side:{side}");
           
        }

        //virtual method to calculate area
        public override double Area()
        {
            return side * side;
           

        }

    }
}
