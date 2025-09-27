using ConsoleAppDelegateAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateAssignment.Service
{
    public class BankImplementation
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        // Create a new account
        public void CreateAccount(int accountNumber, decimal initialBalance = 0)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber] = new BankAccount(accountNumber, initialBalance);
                Console.WriteLine($"Account {accountNumber} created with balance {initialBalance}");
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }

        // Deposit method
        public void Deposit(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].Deposit(amount);
                Console.WriteLine($"Deposited {amount} to Account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        // Withdraw method
        public void Withdraw(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                if (accounts[accountNumber].Withdraw(amount))
                    Console.WriteLine($"Withdrawn {amount} from Account {accountNumber}");
                else
                    Console.WriteLine("Insufficient funds! Transaction cancelled.");
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        // Check balance method
        public void CheckBalance(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine($"Balance of Account {accountNumber}: {accounts[accountNumber].Balance}");
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }
    }
}
