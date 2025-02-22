using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    private ListManager _listManager;
    private List<int> _testList;

    [SetUp]
    public void Setup()
    {
        _listManager = new ListManager();
        _testList = new List<int>();
    }

    [Test]
    public void AddElement_WhenCalled_AddsElementToList()
    {
        _listManager.AddElement(_testList, 5);

        Assert.Contains(5, _testList);
    }

    [Test]
    public void RemoveElement_WhenElementExists_RemovesElementFromList()
    {
        _testList.Add(5);
        _listManager.RemoveElement(_testList, 5);

        Assert.IsFalse(_testList.Contains(5));
    }

    [Test]
    public void RemoveElement_WhenElementDoesNotExist_ListRemainsUnchanged()
    {
        _testList.Add(10);
        _listManager.RemoveElement(_testList, 20);

        Assert.AreEqual(1, _testList.Count);
    }

    [Test]
    public void GetSize_WhenElementsAdded_ReturnsCorrectSize()
    {
        _listManager.AddElement(_testList, 5);
        _listManager.AddElement(_testList, 10);

        Assert.AreEqual(2, _listManager.GetSize(_testList));
    }

    [Test]
    public void GetSize_AfterElementsRemoved_ReturnsCorrectSize()
    {
        _testList.Add(5);
        _testList.Add(10);
        _listManager.RemoveElement(_testList, 5);

        Assert.AreEqual(1, _listManager.GetSize(_testList));
    }

    [Test]
    public void GetSize_WhenListIsEmpty_ReturnsZero()
    {
        Assert.AreEqual(0, _listManager.GetSize(_testList));
    }
}
