using System;

namespace ArraySumApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = Program.SumArray(arr);

            Console.WriteLine($"The sum of array elements is: {result}");
        }
    }
}
