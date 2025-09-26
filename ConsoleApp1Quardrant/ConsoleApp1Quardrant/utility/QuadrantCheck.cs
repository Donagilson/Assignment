using System;

namespace CoordinateQuadrantApp.utility
{
    public static class QuadrantChecker
    {
        public static void CheckQuadrant()
        {
            Console.Write("Enter X coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("The point lies in Quadrant I.");
            else if (x < 0 && y > 0)
                Console.WriteLine("The point lies in Quadrant II.");
            else if (x < 0 && y < 0)
                Console.WriteLine("The point lies in Quadrant III.");
            else if (x > 0 && y < 0)
                Console.WriteLine("The point lies in Quadrant IV.");
            else if (x == 0 && y == 0)
                Console.WriteLine("The point is at the Origin.");
            else if (x == 0)
                Console.WriteLine("The point lies on the Y-axis.");
            else if (y == 0)
                Console.WriteLine("The point lies on the X-axis.");
        }
    }
}