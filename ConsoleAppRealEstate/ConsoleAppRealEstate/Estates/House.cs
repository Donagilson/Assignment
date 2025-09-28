using System;

namespace RealEstateManagement.Estates
{
    public class House : Estate
    {
        public double DevelopedArea { get; set; }
        public double YardArea { get; set; }
        public int Floors { get; set; }
        public bool IsFurnished { get; set; }

        public House(double area, double pricePerSqM, string location, double developed, double yard, int floors, bool furnished)
            : base(area, pricePerSqM, location)
        {
            DevelopedArea = developed;
            YardArea = yard;
            Floors = floors;
            IsFurnished = furnished;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"House in {Location}, Total Area: {Area}, Price: {GetTotalPrice()}, Floors: {Floors}, Developed: {DevelopedArea}, Yard: {YardArea}, Furnished: {IsFurnished}");
        }
    }
}
