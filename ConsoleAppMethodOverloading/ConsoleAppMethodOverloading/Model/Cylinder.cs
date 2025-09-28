using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Cylinder : Shape
    {


        private double radius, height;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public override double Volume()
        {
            return Math.PI * radius * radius * height;
        }
    }
}