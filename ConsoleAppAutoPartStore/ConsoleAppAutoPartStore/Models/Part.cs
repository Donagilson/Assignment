using System;
using System.Collections.Generic;

namespace AutoPartsStore.Models
{
    public class Part
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<CarModel> CompatibleCars { get; set; }

        public Part(string code, string name, string category, double purchasePrice, double salePrice, Manufacturer manufacturer)
        {
            Code = code;
            Name = name;
            Category = category;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            Manufacturer = manufacturer;
            CompatibleCars = new List<CarModel>();
        }

        public void AddCompatibleCar(CarModel car)
        {
            CompatibleCars.Add(car);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nPart Code: {Code}, Name: {Name}, Category: {Category}");
            Console.WriteLine($"Purchase Price: {PurchasePrice}, Sale Price: {SalePrice}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine("Compatible Cars:");
            foreach (var car in CompatibleCars)
            {
                Console.WriteLine($" - {car}");
            }
        }
    }
}
