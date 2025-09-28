using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter starting position:");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter length of substring:");
        int length = Convert.ToInt32(Console.ReadLine());

        string result = "";

        for (int i = start; i < start + length && i < str.Length; i++)
        {
            result += str[i];  // manually building substring
        }

        Console.WriteLine("Substring is: " + result);
    }
}
