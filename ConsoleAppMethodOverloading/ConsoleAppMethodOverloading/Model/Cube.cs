using ConsoleAppShapes.Model;

class Cube : Shape
{
    private double side;

    
    public Cube(double s)
    {
        side = s;
    }

    public override double Volume()
    {
        return side * side * side;
    }
}