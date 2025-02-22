using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_WhenCalled_ReturnsSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Subtract_WhenCalled_ReturnsDifference()
    {
        var result = _calculator.Subtract(5, 3);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Multiply_WhenCalled_ReturnsProduct()
    {
        var result = _calculator.Multiply(2, 3);
        Assert.AreEqual(6, result);
    }

    [Test]
    public void Divide_WhenCalled_ReturnsQuotient()
    {
        var result = _calculator.Divide(6, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
    }
}
