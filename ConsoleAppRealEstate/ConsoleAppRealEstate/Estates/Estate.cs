using System;

namespace RealEstateManagement.Estates
{
    public abstract class Estate
    {
        public double Area { get; set; }
        public double PricePerSquareMeter { get; set; }
        public string Location { get; set; }

        protected Estate(double area, double pricePerSqM, string location)
        {
            Area = area;
            PricePerSquareMeter = pricePerSqM;
            Location = location;
        }

        public virtual double GetTotalPrice() => Area * PricePerSquareMeter;

        public abstract void DisplayDetails();
    }
}
