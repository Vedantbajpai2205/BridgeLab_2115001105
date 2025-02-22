using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter _temperatureConverter;

    [SetUp]
    public void SetUp()
    {
        _temperatureConverter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ValidCelsius_ReturnsCorrectFahrenheit()
    {
        Assert.AreEqual(32, _temperatureConverter.CelsiusToFahrenheit(0));
        Assert.AreEqual(212, _temperatureConverter.CelsiusToFahrenheit(100));
        Assert.AreEqual(50, _temperatureConverter.CelsiusToFahrenheit(10));
        Assert.AreEqual(-40, _temperatureConverter.CelsiusToFahrenheit(-40));
    }

    [Test]
    public void FahrenheitToCelsius_ValidFahrenheit_ReturnsCorrectCelsius()
    {
        Assert.AreEqual(0, _temperatureConverter.FahrenheitToCelsius(32));
        Assert.AreEqual(100, _temperatureConverter.FahrenheitToCelsius(212));
        Assert.AreEqual(10, _temperatureConverter.FahrenheitToCelsius(50));
        Assert.AreEqual(-40, _temperatureConverter.FahrenheitToCelsius(-40));
    }

    [Test]
    public void CelsiusToFahrenheit_ConvertsNegativeCelsius()
    {
        double result = _temperatureConverter.CelsiusToFahrenheit(-10);
        Assert.AreEqual(14, result, 0.1);
    }

    [Test]
    public void FahrenheitToCelsius_ConvertsNegativeFahrenheit()
    {
        double result = _temperatureConverter.FahrenheitToCelsius(-10);
        Assert.AreEqual(-23.33, result, 0.1);
    }
}
