namespace ConsoleAppAssignments.Model
{
    // Base class
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetVolume();
    }

    // Cube
    public class Cube : Shape
    {
        public double Side { get; set; }

        public Cube(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return 6 * Side * Side;
        }

        public override double GetVolume()
        {
            return Side * Side * Side;
        }
    }

    // Sphere
    public class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }

    // Cylinder
    public class Cylinder : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double GetArea()
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }

        public override double GetVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }

    // Cone
    public class Cone : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double GetArea()
        {
            double slant = Math.Sqrt(Radius * Radius + Height * Height);
            return Math.PI * Radius * (Radius + slant);
        }

        public override double GetVolume()
        {
            return (1.0 / 3.0) * Math.PI * Radius * Radius * Height;
        }
    }
}
