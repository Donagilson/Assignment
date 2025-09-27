using ConsoleAppDelegateAssignment.Utility;
using ConsoleAppDelegateAssignment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppDelegateAssignment.Model;

namespace ConsoleAppDelegateAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankImplementation bank = new BankImplementation();

            // Pre-created accounts
            bank.CreateAccount(1001, 500);

            // Delegates wrapping service methods
            TransactionDelegate depositDelegate = bank.Deposit;
            TransactionDelegate withdrawDelegate = bank.Withdraw;

            while (true)
            {
                Console.WriteLine("\n=== Banking System Menu ===");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "4")
                    break;

                Console.Write("Enter Account Number: ");
                if (!int.TryParse(Console.ReadLine(), out int accountNumber))
                {
                    Console.WriteLine("Invalid account number.");
                    continue;
                }

                switch (choice)
                {
                    case "1": // Deposit
                        Console.Write("Enter deposit amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                            depositDelegate(accountNumber, depositAmount);   // delegate call
                        else
                            Console.WriteLine("Invalid deposit amount.");
                        break;

                    case "2": // Withdraw
                        Console.Write("Enter withdrawal amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
                            withdrawDelegate(accountNumber, withdrawAmount); // delegate call
                        else
                            Console.WriteLine("Invalid withdrawal amount.");
                        break;

                    case "3":
                        bank.CheckBalance(accountNumber); // direct call
                        break;
                }
            }
        }
    }
}
