using System;

namespace ConsoleAppVehicle.Models
{
    public class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Vehicle(string licenseNumber, string model, string color)
        {
            LicenseNumber = licenseNumber;
            Model = model;
            Color = color;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"License: {LicenseNumber}, Model: {Model}, Color: {Color}");
        }
    }
}
