using System;
using System.Collections.Generic;

public abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public string HolderName
    {
        get { return holderName; }
    }

    public double Balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public abstract double CalculateInterest();
}

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string holderName, double balance) 
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return Balance * 0.04;
    }
}

public class CurrentAccount : BankAccount
{
    public CurrentAccount(string accountNumber, string holderName, double balance) 
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return Balance * 0.02;
    }
}

public interface ILoanable
{
    void ApplyForLoan(double loanAmount);
    bool CalculateLoanEligibility();
}

public class LoanableAccount : BankAccount, ILoanable
{
    public LoanableAccount(string accountNumber, string holderName, double balance) 
        : base(accountNumber, holderName, balance) { }

    public void ApplyForLoan(double loanAmount)
    {
        if (loanAmount <= Balance * 2) 
        {
            Console.WriteLine("Loan of " + loanAmount + " approved.");
        }
        else
        {
            Console.WriteLine("Loan amount exceeds eligibility.");
        }
    }

    public bool CalculateLoanEligibility()
    {
        return Balance >= 1000;
    }

    public override double CalculateInterest()
    {
        return Balance * 0.03; 
    }
}

class Program4
{
    static void Main(string[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount("S12345", "Yash", 5000);
        CurrentAccount currentAccount = new CurrentAccount("C54321", "Vedant", 2000);
        LoanableAccount loanableAccount = new LoanableAccount("L98765", "Raghav", 3000);

    
        List<BankAccount> accounts = new List<BankAccount> { savingsAccount, currentAccount, loanableAccount };

        foreach (BankAccount account in accounts)
        {
            Console.WriteLine("Account Holder: " + account.HolderName + " | Account Type: " + account.GetType().Name);
            Console.WriteLine("Initial Balance: " + account.Balance);

            account.Deposit(1000);
            account.Withdraw(500);

            Console.WriteLine("Interest: " + account.CalculateInterest());

            if (account is ILoanable loanable)
            {
                loanable.ApplyForLoan(2000);
                Console.WriteLine("Loan Eligibility: " + loanable.CalculateLoanEligibility());
            }

            Console.WriteLine();
        }
    }
}
