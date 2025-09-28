using System;

namespace ConsoleAppInsertInSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];  // Extra space for inserting new element
            int n, i, num, pos = 0;

            Console.Write("Enter the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} elements in ascending order:", n);
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the new element to insert: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Find position where new element should be inserted
            for (i = 0; i < n; i++)
            {
                if (num < arr[i])
                {
                    pos = i;
                    break;
                }
            }

            if (i == n) // if new element is the largest
                pos = n;

            // Shift elements to the right
            for (i = n; i > pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            // Insert the new element
            arr[pos] = num;
            n++;

            Console.WriteLine("Array after insertion:");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
