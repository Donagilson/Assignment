using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegateAssignment.Utility
{
    // Delegate representing a transaction method
    public delegate void TransactionDelegate(int accountNumber, decimal amount);
}