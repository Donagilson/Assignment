using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Cone : Shape
    {


        private double radius, height;

        public Cone(double r, double h)
        {
            radius = r;
            height = h;
        }

        public override double Volume()
        {
            return (1.0 / 3.0) * Math.PI * radius * radius * height;
        }
    }
}