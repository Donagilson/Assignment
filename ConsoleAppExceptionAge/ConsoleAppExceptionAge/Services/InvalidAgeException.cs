using System;

namespace EmployeeApp.Services
{
    // Custom Exception Class
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
}
