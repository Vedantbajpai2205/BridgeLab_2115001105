using System;
using System.Collections.Generic;

    class Banking
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> accounts = new Dictionary<int, double>();
            SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>();
            Queue<int> withdrawalQueue = new Queue<int>();

            AddAccount(101, 1000.00, accounts, sortedAccounts);
            AddAccount(102, 500.00, accounts, sortedAccounts);
            AddAccount(103, 1500.00, accounts, sortedAccounts);
            AddAccount(104, 200.00, accounts, sortedAccounts);

            ProcessWithdrawalRequest(102, 100.00, accounts, withdrawalQueue);
            ProcessWithdrawalRequest(101, 200.00, accounts, withdrawalQueue);
            ProcessWithdrawalRequest(104, 50.00, accounts, withdrawalQueue);

            Console.WriteLine("Customers sorted by account balance:");
            DisplaySortedAccounts(sortedAccounts);

            ProcessWithdrawalQueue(accounts, withdrawalQueue);

            Console.WriteLine("Updated account balances:");
            DisplayAccountBalances(accounts);
        }

        static void AddAccount(int accountNumber, double initialBalance, Dictionary<int, double> accounts, SortedDictionary<int, double> sortedAccounts)
        {
            accounts[accountNumber] = initialBalance;
            sortedAccounts[accountNumber] = initialBalance;
        }

        static void ProcessWithdrawalRequest(int accountNumber, double amount, Dictionary<int, double> accounts, Queue<int> withdrawalQueue)
        {
            if (accounts.ContainsKey(accountNumber) && accounts[accountNumber] >= amount)
            {
                withdrawalQueue.Enqueue(accountNumber);
                Console.WriteLine("Withdrawal request added for account " + accountNumber + " for amount $" + amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid account for withdrawal request.");
            }
        }

        static void ProcessWithdrawalQueue(Dictionary<int, double> accounts, Queue<int> withdrawalQueue)
        {
            while (withdrawalQueue.Count > 0)
            {
                int accountNumber = withdrawalQueue.Dequeue();
                double withdrawalAmount = 100.00;
                if (accounts[accountNumber] >= withdrawalAmount)
                {
                    accounts[accountNumber] -= withdrawalAmount;
                    Console.WriteLine("Processed withdrawal for account " + accountNumber + " of " + withdrawalAmount);
                }
                else
                {
                    Console.WriteLine("Insufficient funds for withdrawal request for account " + accountNumber);
                }
            }
        }

        static void DisplaySortedAccounts(SortedDictionary<int, double> sortedAccounts)
        {
            foreach (var account in sortedAccounts)
            {
                Console.WriteLine("Account " + account.Key + ": " + account.Value);
            }
        }

        static void DisplayAccountBalances(Dictionary<int, double> accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine("Account " + account.Key + ": " + account.Value);
            }
        }
    }
