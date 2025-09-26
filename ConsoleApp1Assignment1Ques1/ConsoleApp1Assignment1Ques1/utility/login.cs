using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.utility
{
    public static class inventory
    {
        public static void Login()
        {
            string userId = "admin";
            string password = "1234";

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter User ID: ");
                string inputUser = Console.ReadLine();

                Console.Write("Enter Password: ");
                string inputPass = Console.ReadLine();

                if (inputUser == userId && inputPass == password)
                {
                    Console.WriteLine("Login Successful!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Wrong credentials. Attempts left: {3 - i}");
                }
            }

            Console.WriteLine("Access Denied.");
        }
    }
}