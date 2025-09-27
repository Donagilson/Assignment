namespace utility
{
    public static class efficiency
    {
        // L/100km = (fuel / distance) * 100
        public static double CalculateLitersPer100km(double distance, double fuel)
        {
            return (fuel / distance) * 100;
        }

        // Convert L/100km to MPG (using UK MPG conversion factor)
        public static double Converttompg(double lper100km)
        {
            return 282.481 / lper100km;
        }
    }
}
