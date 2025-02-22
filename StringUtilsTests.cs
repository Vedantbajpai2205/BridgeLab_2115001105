using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    private StringUtils _stringUtils;

    [SetUp]
    public void Setup()
    {
        _stringUtils = new StringUtils();
    }

    [Test]
    public void Reverse_WhenCalled_ReturnsReversedString()
    {
        var result = _stringUtils.Reverse("hello");
        Assert.AreEqual("olleh", result);
    }

    [Test]
    public void IsPalindrome_WhenPalindrome_ReturnsTrue()
    {
        var result = _stringUtils.IsPalindrome("madam");
        Assert.IsTrue(result);
    }

    [Test]
    public void IsPalindrome_WhenNotPalindrome_ReturnsFalse()
    {
        var result = _stringUtils.IsPalindrome("hello");
        Assert.IsFalse(result);
    }

    [Test]
    public void IsPalindrome_WhenStringWithDifferentCase_ReturnsTrue()
    {
        var result = _stringUtils.IsPalindrome("MadAm");
        Assert.IsTrue(result);
    }

    [Test]
    public void ToUpperCase_WhenCalled_ReturnsUpperCaseString()
    {
        var result = _stringUtils.ToUpperCase("hello");
        Assert.AreEqual("HELLO", result);
    }

    [Test]
    public void Reverse_WhenNullString_ReturnsNull()
    {
        var result = _stringUtils.Reverse(null);
        Assert.IsNull(result);
    }

    [Test]
    public void IsPalindrome_WhenNullString_ReturnsFalse()
    {
        var result = _stringUtils.IsPalindrome(null);
        Assert.IsFalse(result);
    }

    [Test]
    public void ToUpperCase_WhenNullString_ReturnsNull()
    {
        var result = _stringUtils.ToUpperCase(null);
        Assert.IsNull(result);
    }
}
