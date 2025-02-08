using System;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("This is a general bank account.");
    }
}

public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Savings Account.");
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Checking Account.");
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}

public class FixedDepositAccount : BankAccount
{
    public DateTime MaturityDate { get; set; }

    public FixedDepositAccount(string accountNumber, double balance, DateTime maturityDate)
        : base(accountNumber, balance)
    {
        MaturityDate = maturityDate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Fixed Deposit Account.");
        Console.WriteLine("Maturity Date: " + MaturityDate.ToShortDateString());
    }
    public static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("12345", 1500.00, 3.5);
        CheckingAccount checking = new CheckingAccount("67890", 2000.00, 500.00);
        FixedDepositAccount fd = new FixedDepositAccount("24680", 10000.00, DateTime.Now.AddYears(1));

        Console.WriteLine("Account Info (Savings):");
        savings.DisplayAccountType();
        Console.WriteLine();

        Console.WriteLine("Account Info (Checking):");
        checking.DisplayAccountType();
        Console.WriteLine();

        Console.WriteLine("Account Info (Fixed Deposit):");
        fd.DisplayAccountType();
    }
}
