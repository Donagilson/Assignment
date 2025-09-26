using System;

namespace Assignment3_OddEven
{
    public class Utility
    {
        public static void SeparateOddEven()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Arrays to store odd & even
            int[] even = new int[n];
            int[] odd = new int[n];
            int evenCount = 0, oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[evenCount] = arr[i];
                    evenCount++;
                }
                else
                {
                    odd[oddCount] = arr[i];
                    oddCount++;
                }
            }

            Console.Write("Even numbers: ");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(even[i] + " ");
            }

            Console.Write("\nOdd numbers: ");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
    }
}
