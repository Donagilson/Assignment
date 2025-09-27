using System;
using ConsoleAppPhoneIndex.Models;

namespace ConsoleAppPhoneIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneIndex index = new PhoneIndex();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Phone Index Menu ---");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. Find Entry");
                Console.WriteLine("3. Display All");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        string phone = Console.ReadLine();
                        index.AddEntry(name, phone);
                        break;

                    case "2":
                        Console.Write("Enter Name to Search: ");
                        string searchName = Console.ReadLine();
                        index.FindEntry(searchName);
                        break;

                    case "3":
                        index.DisplayAll();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting Phone Index...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
