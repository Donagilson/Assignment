using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter second string:");
        string str2 = Console.ReadLine();

        bool equal = true;

        if (str1.Length != str2.Length)
            equal = false;
        else
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    equal = false;
                    break;
                }
            }
        }

        Console.WriteLine(equal ? "Strings are equal." : "Strings are not equal.");
    }
}
