

public class BankAccount
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }
}

public class Bank
{
    private Dictionary<int, BankAccount> accounts = new();

    public void AddAccount(int accNumber, decimal initialBalance)
    {
        accounts[accNumber] = new BankAccount { AccountNumber = accNumber, Balance = initialBalance };
    }

    public void Deposit(BankAccount account, decimal amount)
    {
        account.Balance += amount;
        Console.WriteLine($"Deposited {amount}, New Balance: {account.Balance}");
    }

    public void Withdraw(BankAccount account, decimal amount)
    {
        if (account.Balance >= amount)
        {
            account.Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}, New Balance: {account.Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    public void CheckBalance(BankAccount account, decimal _)
    {
        Console.WriteLine($"Current Balance: {account.Balance}");
    }

    public BankAccount GetAccount(int accNumber)
    {
        return accounts.ContainsKey(accNumber) ? accounts[accNumber] : null;
    }
}
