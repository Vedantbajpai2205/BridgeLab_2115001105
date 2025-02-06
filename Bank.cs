using System;
using System.Collections.Generic;

class Account
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public Account(int accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0; 
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Deposited " + amount + " into account " + AccountNumber + " . New balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrew " + amount + " from account " + AccountNumber + " . New balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine("Account " + AccountNumber + " balance: " + Balance);
    }
}

class Customer
{
    public string Name { get; set; }
    public List<Account> Accounts { get; set; }

    public Customer(string name)
    {
        Name = name;
        Accounts = new List<Account>();
    }

    public void ViewAllAccounts()
    {
        Console.WriteLine(Name+"'s Accounts:");
        foreach (var account in Accounts)
        {
            account.ViewBalance();
        }
    }
}

class Bank
{
    public string BankName { get; set; }
    public List<Customer> Customers { get; set; }

    public Bank(string bankName)
    {
        BankName = bankName;
        Customers = new List<Customer>();
    }

    public void OpenAccount(Customer customer)
    {
        Account newAccount = new Account(GenerateAccountNumber());
        customer.Accounts.Add(newAccount);
        Customers.Add(customer);
        Console.WriteLine("Account opened for " + customer.Name + " with Account Number: " + newAccount.AccountNumber);
    }

    private int GenerateAccountNumber()
    {
        Random rand = new Random();
        return rand.Next(100000, 999999);
    }
    static void Main()
    {
        Bank bank = new Bank("SBI Bank");
        Customer customer1 = new Customer("Yash");
        Customer customer2 = new Customer("Vedant");

        bank.OpenAccount(customer1);
        bank.OpenAccount(customer2);

        customer1.Accounts[0].Deposit(500);
        customer1.Accounts[0].Withdraw(200);

        customer2.Accounts[0].Deposit(1000);
        customer2.Accounts[0].Withdraw(150);

        customer1.ViewAllAccounts();
        customer2.ViewAllAccounts();
    }
}
