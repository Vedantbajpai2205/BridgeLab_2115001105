using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection _dbConnection;

    [SetUp]
    public void SetUp()
    {
        _dbConnection = new DatabaseConnection();
        _dbConnection.Connect();
    }

    [TearDown]
    public void TearDown()
    {
        _dbConnection.Disconnect();
    }

    [Test]
    public void Connect_WhenCalled_SetsIsConnectedToTrue()
    {
        Assert.IsTrue(_dbConnection.IsConnected);
    }

    [Test]
    public void Disconnect_WhenCalled_SetsIsConnectedToFalse()
    {
        _dbConnection.Disconnect();
        Assert.IsFalse(_dbConnection.IsConnected);
    }

    [Test]
    public void ConnectionIsProperlyClosed_AfterTearDown()
    {
        Assert.IsTrue(_dbConnection.IsConnected);
        _dbConnection.Disconnect();
        Assert.IsFalse(_dbConnection.IsConnected);
    }
}
