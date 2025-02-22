using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator _passwordValidator;

    [SetUp]
    public void SetUp()
    {
        _passwordValidator = new PasswordValidator();
    }

    [Test]
    public void IsValid_WhenPasswordIsValid_ReturnsTrue()
    {
        Assert.IsTrue(_passwordValidator.IsValid("Valid123"));
        Assert.IsTrue(_passwordValidator.IsValid("Password1"));
        Assert.IsTrue(_passwordValidator.IsValid("MyPass123"));
    }

    [Test]
    public void IsValid_WhenPasswordIsTooShort_ReturnsFalse()
    {
        Assert.IsFalse(_passwordValidator.IsValid("Short1"));
    }

    [Test]
    public void IsValid_WhenPasswordHasNoUppercase_ReturnsFalse()
    {
        Assert.IsFalse(_passwordValidator.IsValid("password123"));
    }

    [Test]
    public void IsValid_WhenPasswordHasNoDigit_ReturnsFalse()
    {
        Assert.IsFalse(_passwordValidator.IsValid("Password"));
    }

    [Test]
    public void IsValid_WhenPasswordIsEmpty_ReturnsFalse()
    {
        Assert.IsFalse(_passwordValidator.IsValid(""));
    }

    [Test]
    public void IsValid_WhenPasswordHasNoUppercaseAndNoDigit_ReturnsFalse()
    {
        Assert.IsFalse(_passwordValidator.IsValid("password"));
    }
}
