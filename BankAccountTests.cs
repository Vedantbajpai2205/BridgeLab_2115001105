using NUnit.Framework;

[TestFixture]
public class BankAccountTests
{
    private BankAccount _account;

    [SetUp]
    public void SetUp()
    {
        _account = new BankAccount();
    }

    [Test]
    public void Deposit_WhenCalled_UpdatesBalanceCorrectly()
    {
        _account.Deposit(100);
        Assert.AreEqual(100, _account.GetBalance());

        _account.Deposit(50);
        Assert.AreEqual(150, _account.GetBalance());
    }

    [Test]
    public void Withdraw_WhenSufficientFunds_UpdatesBalanceCorrectly()
    {
        _account.Deposit(200);
        bool result = _account.Withdraw(100);

        Assert.IsTrue(result);
        Assert.AreEqual(100, _account.GetBalance());
    }

    [Test]
    public void Withdraw_WhenInsufficientFunds_FailsAndBalanceUnchanged()
    {
        _account.Deposit(100);
        bool result = _account.Withdraw(150);

        Assert.IsFalse(result);
        Assert.AreEqual(100, _account.GetBalance());
    }

    [Test]
    public void Withdraw_WhenNegativeAmount_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _account.Withdraw(-50));
        Assert.AreEqual("Withdrawal amount must be positive.", ex.Message);
    }

    [Test]
    public void Deposit_WhenNegativeAmount_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _account.Deposit(-50));
        Assert.AreEqual("Deposit amount must be positive.", ex.Message);
    }
}
