using System;

namespace RealEstateManagement.Estates
{
    public class UndevelopedLand : Estate
    {
        public UndevelopedLand(double area, double pricePerSqM, string location)
            : base(area, pricePerSqM, location) { }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Undeveloped Land in {Location}, Area: {Area}, Price: {GetTotalPrice()}");
        }
    }
}
