using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        int alphabets = 0, digits = 0, special = 0;

        foreach (char c in str)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                alphabets++;
            else if (c >= '0' && c <= '9')
                digits++;
            else
                special++;
        }

        Console.WriteLine($"Alphabets: {alphabets}");
        Console.WriteLine($"Digits: {digits}");
        Console.WriteLine($"Special Characters: {special}");
    }
}
