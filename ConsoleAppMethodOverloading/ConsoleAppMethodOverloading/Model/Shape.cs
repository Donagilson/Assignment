using System;

namespace ConsoleAppShapes.Model
{
    public class Shape
    {

        public virtual double Volume()
        {
            // Default cube of side 10
            double side = 10;
            return side * side * side;
        }
    }
}