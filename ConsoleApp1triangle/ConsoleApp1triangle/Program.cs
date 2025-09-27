using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the number to display: ");
        int num = Convert.ToInt32(Console.ReadLine());

     
        Console.Write("Enter the width of the triangle: ");
        int width = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
