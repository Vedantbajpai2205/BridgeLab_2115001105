using NUnit.Framework;

[TestFixture]
public class MathOperationsTests
{
    private MathOperations _mathOperations;

    [SetUp]
    public void Setup()
    {
        _mathOperations = new MathOperations();
    }

    [Test]
    public void Divide_WhenDividingByZero_ThrowsArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => _mathOperations.Divide(10, 0));
    }

    [Test]
    public void Divide_WhenDividingByNonZero_ReturnsCorrectResult()
    {
        var result = _mathOperations.Divide(10, 2);
        Assert.AreEqual(5, result);
    }
}
