using NUnit.Framework;

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter _dateFormatter;

    [SetUp]
    public void SetUp()
    {
        _dateFormatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidDate_ReturnsCorrectFormat()
    {
        string result = _dateFormatter.FormatDate("2025-02-22");
        Assert.AreEqual("22-02-2025", result);

        result = _dateFormatter.FormatDate("2000-12-31");
        Assert.AreEqual("31-12-2000", result);
    }

    [Test]
    public void FormatDate_InvalidDateFormat_ThrowsFormatException()
    {
        var ex = Assert.Throws<FormatException>(() => _dateFormatter.FormatDate("22-02-2025"));
        Assert.AreEqual("Invalid date format.", ex.Message);
    }

    [Test]
    public void FormatDate_EmptyDate_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _dateFormatter.FormatDate(""));
        Assert.AreEqual("Input date cannot be null or empty.", ex.Message);
    }

    [Test]
    public void FormatDate_NullDate_ThrowsArgumentException()
    {
        var ex = Assert.Throws<ArgumentException>(() => _dateFormatter.FormatDate(null));
        Assert.AreEqual("Input date cannot be null or empty.", ex.Message);
    }

    [Test]
    public void FormatDate_InvalidDate_ThrowsFormatException()
    {
        var ex = Assert.Throws<FormatException>(() => _dateFormatter.FormatDate("2025-02-30"));
        Assert.AreEqual("Invalid date format.", ex.Message);
    }
}
