namespace FibonacciApp
{
    public class Program
    {
        public static void Fibonacci(int n)
        {
            int first = 0, second = 1, next;

            for (int i = 0; i < n; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
