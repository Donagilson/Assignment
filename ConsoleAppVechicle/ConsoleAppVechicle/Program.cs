using System;
using ConsoleAppVehicle.Models;

namespace ConsoleAppVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleRegistration registry = new VehicleRegistration();

            // Register vehicles
            registry.RegisterVehicle(new Vehicle("KA01AB1234", "Honda City", "White"));
            registry.RegisterVehicle(new Vehicle("KA02XY5678", "Hyundai Creta", "Black"));
            registry.RegisterVehicle(new Vehicle("KA03LM9999", "Maruti Swift", "Red"));

            // Retrieve by license number
            Console.Write("\nEnter license number to search: ");
            string licenseInput = Console.ReadLine();

            Vehicle foundVehicle = registry.GetVehicle(licenseInput);
            if (foundVehicle != null)
            {
                Console.WriteLine("\nVehicle Found:");
                foundVehicle.DisplayInfo();
            }

            // Display all registered vehicles
            registry.DisplayAll();
        }
    }
}
