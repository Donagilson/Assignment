using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapes.Model
{
    public class Sphere : Shape

    {
        private double radius;

        public Sphere(double r)
        {
            radius = r;
        }

        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * radius * radius;
        }
    }
}