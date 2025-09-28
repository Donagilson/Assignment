using System;

namespace TemperatureEventApp.Model
{
    // Custom EventArgs to pass temperature data with the event
    public class TemperatureEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
