using System;
using TemperatureEventApp.Service;
using TemperatureEventApp.Model;

namespace TemperatureEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            // Subscribe to the event
            sensor.CriticalTemperatureReached += Sensor_CriticalTemperatureReached;

            Console.Write("Enter number of temperature readings: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter temperature reading {i + 1}: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                sensor.UpdateTemperature(temp);
            }

            Console.WriteLine("\nMonitoring finished.");
        }

        // Event handler method
        private static void Sensor_CriticalTemperatureReached(object sender, TemperatureEventArgs e)
        {
            Console.WriteLine($"⚠️ Critical temperature reached: {e.Temperature}°C");
        }
    }
}
