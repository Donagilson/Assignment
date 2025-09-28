namespace ConsoleAppAssignments.Model
{
    public class Rectangle
    {
        // Properties
        public int X { get; set; }
        public int Y { get; set; }

        // Default Constructor
        public Rectangle()
        {
            X = 0;
            Y = 0;
        }

        // Parameterized Constructor
        public Rectangle(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to calculate area
        public int GetArea()
        {
            return X * Y;
        }

        // Display rectangle details
        public void Display()
        {
            Console.WriteLine($"Rectangle: X = {X}, Y = {Y}, Area = {GetArea()}");
        }
    }
}
