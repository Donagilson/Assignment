using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateAssignment.Model
{
    public class BankAccount
    {
        public int AccNo { get; set; }
        public decimal Balance { get; set; }
        public BankAccount(int accNo, decimal balance)
        {
            AccNo = accNo;
            Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
