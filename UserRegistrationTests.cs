using NUnit.Framework;

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration _userRegistration;

    [SetUp]
    public void SetUp()
    {
        _userRegistration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInputs_RegistrationSuccessful()
    {
        Assert.DoesNotThrow(() => _userRegistration.RegisterUser("validUser", "user@example.com", "StrongPass1"));
    }

    [Test]
    public void RegisterUser_EmptyUsername_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("", "user@example.com", "StrongPass1"));
        Assert.AreEqual("Username cannot be empty.", ex.Message);
    }

    [Test]
    public void RegisterUser_InvalidEmail_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("validUser", "invalidemail.com", "StrongPass1"));
        Assert.AreEqual("Invalid email address.", ex.Message);
    }

    [Test]
    public void RegisterUser_ShortPassword_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("validUser", "user@example.com", "Short1"));
        Assert.AreEqual("Password must be at least 8 characters long.", ex.Message);
    }

    [Test]
    public void RegisterUser_EmptyEmail_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("validUser", "", "StrongPass1"));
        Assert.AreEqual("Invalid email address.", ex.Message);
    }

    [Test]
    public void RegisterUser_EmptyPassword_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("validUser", "user@example.com", ""));
        Assert.AreEqual("Password must be at least 8 characters long.", ex.Message);
    }
}
