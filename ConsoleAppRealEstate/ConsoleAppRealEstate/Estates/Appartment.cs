using System;

namespace RealEstateManagement.Estates
{
    public class Apartment : Estate
    {
        public int FloorNumber { get; set; }
        public bool HasElevator { get; set; }
        public bool IsFurnished { get; set; }

        public Apartment(double area, double pricePerSqM, string location, int floor, bool elevator, bool furnished)
            : base(area, pricePerSqM, location)
        {
            FloorNumber = floor;
            HasElevator = elevator;
            IsFurnished = furnished;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Apartment in {Location}, Area: {Area}, Price: {GetTotalPrice()}, Floor: {FloorNumber}, Elevator: {HasElevator}, Furnished: {IsFurnished}");
        }
    }
}
