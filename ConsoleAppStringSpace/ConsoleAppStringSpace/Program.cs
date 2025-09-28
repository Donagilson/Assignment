using System;

namespace SpaceCounterApp
{
    public class Program
    {
        // Method to count spaces in a string
        public static int CountSpaces(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
