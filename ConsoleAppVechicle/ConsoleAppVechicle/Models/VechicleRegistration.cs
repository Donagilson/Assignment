using System;
using System.Collections.Generic;

namespace ConsoleAppVehicle.Models
{
    public class VehicleRegistration
    {
        private Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

        // Add Vehicle
        public void RegisterVehicle(Vehicle vehicle)
        {
            if (!vehicles.ContainsKey(vehicle.LicenseNumber))
            {
                vehicles.Add(vehicle.LicenseNumber, vehicle);
                Console.WriteLine($" Vehicle with license {vehicle.LicenseNumber} registered successfully.");
            }
            else
            {
                Console.WriteLine($" Vehicle with license {vehicle.LicenseNumber} is already registered.");
            }
        }

        // Retrieve by License
        public Vehicle GetVehicle(string licenseNumber)
        {
            if (vehicles.ContainsKey(licenseNumber))
            {
                return vehicles[licenseNumber];
            }
            else
            {
                Console.WriteLine($" Vehicle with license {licenseNumber} not found.");
                return null;
            }
        }

        // Display all vehicles
        public void DisplayAll()
        {
            Console.WriteLine("\n--- Registered Vehicles ---");
            foreach (var pair in vehicles)
            {
                pair.Value.DisplayInfo();
            }
        }
    }
}
