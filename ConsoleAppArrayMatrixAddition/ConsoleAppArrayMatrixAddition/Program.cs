using System;

namespace ConsoleAppArrayMatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Rows");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arrone = new int[n, m];
            int[,] arrtwo = new int[n, m];
            int[,] sum = new int[n, m];

            Console.WriteLine("Enter the Elements for arrone");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"arrone[{i},{j}]: ");
                    arrone[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the Elements for arrtwo");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"arrtwo[{i},{j}]: ");
                    arrtwo[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Adding two matrices
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum[i, j] = arrone[i, j] + arrtwo[i, j];
                }
            }

            Console.WriteLine("\nResultant Matrix (Sum):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
