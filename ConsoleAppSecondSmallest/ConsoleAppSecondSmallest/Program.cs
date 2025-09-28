using System;

namespace ConsoleAppSecondSmallestBubble
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Read size
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Array must have at least 2 elements.");
                return;
            }

            // Read array
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Bubble sort in order to arrange the elements
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Find the second smallest
            int smallest = arr[0];
            int secondSmallest = int.MaxValue;
            bool found = false;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] != smallest)
                {
                    secondSmallest = arr[i];
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("No second smallest element (all elements are equal).");
            else
                Console.WriteLine("The second smallest element is: " + secondSmallest);
        }
    }
}
