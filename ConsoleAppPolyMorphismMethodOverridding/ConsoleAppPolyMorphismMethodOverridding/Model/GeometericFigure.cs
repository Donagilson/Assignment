using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismMethodOverridding.Model
{

    //base class
     public class GeometericFigure 
    {


        //common feilds /attribute/ propertise
        public int NoofSides { get; set; }

        //default constructors
        public GeometericFigure()
        {
            
        }

        //parameterized constructors

        //method to accept sides

        public virtual void Accept()
        {
            Console.WriteLine("Enter the number of sides");
            NoofSides = int.Parse(Console.ReadLine());
        }

        //Virtual method to display

        public virtual void Display()
        {
            Console.WriteLine($"Number of sides:{NoofSides}");
        }

        //virtual method to calculate area
        public virtual double Area()
        {
            return 0;// default no meaning full here.

        }

    }
}
