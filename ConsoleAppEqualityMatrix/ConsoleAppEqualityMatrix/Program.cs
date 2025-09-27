namespace ConsoleAppEqualityMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array1 = new int[m, n];
            int[,] array2 = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine($"Matrix A[{i},{j}]");
                    array1[i,j] = Convert.ToInt32(Console.ReadLine());
                    

                }
              
               
            }
            

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Matrix B[{i},{j}]");
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }


            //  Checking Equality
            bool equal = true;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array1[i, j] != array2[i, j])
                    {
                        equal = false;
                        break; // exit inner loop
                    }
                }
                if (!equal) break; // exit outer loop
            }

            //  Output Result
            if (equal)
                Console.WriteLine("\nBoth matrices are EQUAL.");
            else
                Console.WriteLine("\nBoth matrices are NOT equal.");
        }
    }
}
        
    

