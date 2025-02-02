using System;

class BankAccount
{
    public string AccountNumber { get; set; }

    protected string AccountHolder { get; set; }

    private double Balance { get; set; }

    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public double GetBalance()
    {
        return Balance;
    }

    public void SetBalance(double amount)
    {
        if (amount >= 0)
        {
            Balance = amount;
        }
        else
        {
            Console.WriteLine("Invalid amount. Balance cannot be negative.");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + AccountHolder);
        Console.WriteLine("Balance: " + Balance);
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, double balance)
        : base(accountNumber, accountHolder, balance)
    {
    }

    public void DisplaySavingsAccountDetails()
    {
        Console.WriteLine("Savings Account Details:");
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + AccountHolder);
        Console.WriteLine("Balance: " + GetBalance());
    }
}

class Balancebank
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("12345", "John Doe", 1000.00);

        account1.DisplayAccountDetails();

        account1.SetBalance(1500.00);
        Console.WriteLine("Updated Balance: " + account1.GetBalance());
        Console.WriteLine();

        SavingsAccount savingsAccount = new SavingsAccount("98765", "Alice Smith", 5000.00);

        savingsAccount.DisplaySavingsAccountDetails();
    }
}
