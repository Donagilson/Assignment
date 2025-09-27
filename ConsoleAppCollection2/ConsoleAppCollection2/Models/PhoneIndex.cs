using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace ConsoleAppPhoneIndex.Models
{
    public class PhoneIndex
    {
        private SortedList phoneBook = new SortedList();

        // Validate Name (should not be empty, only letters and spaces allowed)
        private bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine(" Name cannot be empty.");
                return false;
            }

            if (!Regex.IsMatch(name, @"^[A-Za-z\s]+$"))
            {
                Console.WriteLine(" Name can only contain letters and spaces.");
                return false;
            }

            return true;
        }

        // Validate Phone Number (only digits, 10 digits long)
        private bool ValidatePhone(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                Console.WriteLine(" Phone number cannot be empty.");
                return false;
            }

            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                Console.WriteLine(" Phone number must be exactly 10 digits.");
                return false;
            }

            return true;
        }

        // Add entry
        public void AddEntry(string name, string phoneNumber)
        {
            if (!ValidateName(name) || !ValidatePhone(phoneNumber))
            {
                Console.WriteLine(" Entry not added due to invalid input.");
                return;
            }

            if (!phoneBook.ContainsKey(name))
            {
                phoneBook.Add(name, phoneNumber);
                Console.WriteLine($" {name} added successfully.");
            }
            else
            {
                Console.WriteLine($" {name} already exists in the phone index.");
            }
        }

        // Find entry
        public void FindEntry(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"{name}: {phoneBook[name]}");
            }
            else
            {
                Console.WriteLine($"{name} not found in the phone index.");
            }
        }

        // Display all entries
        public void DisplayAll()
        {
            Console.WriteLine("\n--- Phone Index ---");
            foreach (DictionaryEntry entry in phoneBook)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
        }
    }
}
