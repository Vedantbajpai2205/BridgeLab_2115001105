using System;

class BankAccount
{
    public static string BankName { get; set; }
    private static int totalAccounts = 0;
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    public readonly string AccountNumber;

    public string AccountHolderName { get; set; }

    public BankAccount(string accountHolderName, string accountNumber)
    {
        this.AccountHolderName = accountHolderName; 
        this.AccountNumber = accountNumber; 
        totalAccounts++; 
    }

    public void DisplayAccountDetails()
    {
        if (this is BankAccount) 
        {
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Account Holder Name: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
        }
        else
        {
            Console.WriteLine("This is not a valid BankAccount instance.");
        }
    }
}
class Bank1
{
    static void Main(string[] args)
    {
		BankAccount.BankName = "SBI Bank";
        BankAccount account1 = new BankAccount("Yash Bajpai", "ACC123456");
        BankAccount account2 = new BankAccount("Raghav Shukla", "ACC789101");

        account1.DisplayAccountDetails();
        Console.WriteLine();
        account2.DisplayAccountDetails();

        Console.WriteLine();
        BankAccount.GetTotalAccounts(); 
    }
}
