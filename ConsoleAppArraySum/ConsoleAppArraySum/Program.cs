namespace ArraySumApp
{
    public class Program
    {
        public static int SumArray(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
