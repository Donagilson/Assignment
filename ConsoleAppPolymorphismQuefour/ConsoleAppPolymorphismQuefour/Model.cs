namespace ConsoleAppAssignments.Model
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetVolume();
    }

    public class Cube : Shape
    {
        private double side;

        public Cube(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return 6 * side * side;
        }

        public override double GetVolume()
        {
            return side * side * side;
        }
    }

    public class Sphere : Shape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return 4 * Math.PI * radius * radius;
        }

        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

    public class Cylinder : Shape
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double GetArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public override double GetVolume()
        {
            return Math.PI * radius * radius * height;
        }
    }

    public class Cone : Shape
    {
        private double radius;
        private double height;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double GetArea()
        {
            double slantHeight = Math.Sqrt(radius * radius + height * height);
            return Math.PI * radius * (radius + slantHeight);
        }

        public override double GetVolume()
        {
            return (1.0 / 3.0) * Math.PI * radius * radius * height;
        }
    }
}