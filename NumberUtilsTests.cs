using NUnit.Framework;

[TestFixture]
public class NumberUtilsTests
{
    private NumberUtils _numberUtils;

    [SetUp]
    public void SetUp()
    {
        _numberUtils = new NumberUtils();
    }

    [TestCase(2, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = true)]
    [TestCase(6, ExpectedResult = true)]
    [TestCase(7, ExpectedResult = false)]
    [TestCase(9, ExpectedResult = false)]
    public bool IsEven_Test(int number)
    {
        return _numberUtils.IsEven(number);
    }
}
