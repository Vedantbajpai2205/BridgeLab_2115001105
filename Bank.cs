using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative.");
        }

        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        balance -= amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Bank
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(500.0);
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
            Console.WriteLine("Withdrawal successful, new balance: " + account.GetBalance());
        }
        catch (InsufficientFundsException)
        {
            Console.WriteLine("Insufficient balance!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid amount!");
        }
    }
}
