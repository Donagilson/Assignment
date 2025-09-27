using System;

namespace ConsoleAppBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //  Bubble Sort
            for (int i = 0; i < n - 1; i++)   // passes
            {
                for (int j = 0; j < n - i - 1; j++)  // comparisons
                {
                    if (arr[j] > arr[j + 1])   // swap if out of order
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            //  Print Sorted Array
            Console.WriteLine("\nSorted Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
