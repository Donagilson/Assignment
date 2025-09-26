using System;

namespace SimpleDuplicateCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int duplicateCount = 0;

            // Compare each element with the rest of the elements
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicateCount++;
                        break; // stop after finding first duplicate of arr[i]
                    }
                }
            }

            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
        }
    }
}

