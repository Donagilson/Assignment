using System;
using AutoPartsStore.Models;

namespace AutoPartsStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manufacturer
            Manufacturer bosch = new Manufacturer("Bosch", "Germany", "Berlin St. 45", "+49-111111", "+49-222222");

            // Parts
            Part brakePad = new Part("P001", "Brake Pad", "Suspension", 1500, 2500, bosch);
            brakePad.AddCompatibleCar(new CarModel("Mercedes", "C320", 2008));
            brakePad.AddCompatibleCar(new CarModel("BMW", "X5", 2010));

            Part oilFilter = new Part("P002", "Oil Filter", "Engine", 500, 1000, bosch);
            oilFilter.AddCompatibleCar(new CarModel("Audi", "A4", 2012));

            // Store
            Store store = new Store();
            store.AddPart(brakePad);
            store.AddPart(oilFilter);

            // Display
            store.DisplayAllParts();

            // Search
            Console.Write("\nEnter part code to search: ");
            string searchCode = Console.ReadLine();

            Part found = store.FindPartByCode(searchCode);
            if (found != null)
            {
                Console.WriteLine("\n Part Found:");
                found.DisplayInfo();
            }
            else
            {
                Console.WriteLine(" Part not found.");
            }
        }
    }
}
