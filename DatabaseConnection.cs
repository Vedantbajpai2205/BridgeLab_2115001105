public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect()
    {
        IsConnected = true;
    }

    public void Disconnect()
    {
        IsConnected = false;
    }
}
