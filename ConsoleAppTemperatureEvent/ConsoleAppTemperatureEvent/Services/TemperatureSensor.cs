using System;
using TemperatureEventApp.Model;

namespace TemperatureEventApp.Service
{
    // Step 1: Define a delegate
    public delegate void TemperatureEventHandler(object sender, TemperatureEventArgs e);

    // Step 2: Publisher class
    public class TemperatureSensor
    {
        private int _temperature;

        // Step 3: Declare the event
        public event TemperatureEventHandler CriticalTemperatureReached;

        // Method to update the temperature
        public void UpdateTemperature(int newTemp)
        {
            int oldTemp = _temperature;
            _temperature = newTemp;

            if (_temperature > oldTemp)
                Console.WriteLine($"Temperature increased to {_temperature}°C");
            else if (_temperature < oldTemp)
                Console.WriteLine($"Temperature decreased to {_temperature}°C");
            else
                Console.WriteLine($"Temperature unchanged at {_temperature}°C");

            // Check if critical condition is reached
            if (_temperature > 100 || _temperature < 0)
            {
                OnCriticalTemperatureReached(new TemperatureEventArgs(_temperature));
            }
        }

        // Step 4: Protected method to raise the event
        protected virtual void OnCriticalTemperatureReached(TemperatureEventArgs e)
        {
            CriticalTemperatureReached?.Invoke(this, e);
        }
    }
}
