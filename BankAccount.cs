public class BankAccount
{
    private double _balance;

    public BankAccount()
    {
        _balance = 0;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        _balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (_balance >= amount)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }

    public double GetBalance()
    {
        return _balance;
    }
}
