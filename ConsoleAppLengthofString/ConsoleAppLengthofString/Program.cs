using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        int length = 0;

        foreach (char c in str)
        {
            length++;
        }

        Console.WriteLine($"Length of the string: {length}");
    }
}
