using System;

namespace RealEstateManagement.Estates
{
    public class Shop : Estate
    {
        public string Category { get; set; }

        public Shop(double area, double pricePerSqM, string location, string category)
            : base(area, pricePerSqM, location)
        {
            Category = category;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Shop in {Location}, Area: {Area}, Price: {GetTotalPrice()}, Category: {Category}");
        }
    }
}
