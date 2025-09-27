using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        int count = 1; // At least one word is there if string is not empty

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                count++;
            }
        }

        Console.WriteLine("Total number of words: " + count);
    }
}
