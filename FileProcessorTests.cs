using NUnit.Framework;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor _fileProcessor;
    private string _testFilename;

    [SetUp]
    public void SetUp()
    {
        _fileProcessor = new FileProcessor();
        _testFilename = "testfile.txt";
    }

    [TearDown]
    public void TearDown()
    {
        if (File.Exists(_testFilename))
        {
            File.Delete(_testFilename);
        }
    }

    [Test]
    public void WriteToFile_WhenCalled_FileExistsAndContentIsWritten()
    {
        string content = "Hello, world!";
        _fileProcessor.WriteToFile(_testFilename, content);

        Assert.IsTrue(File.Exists(_testFilename));
        string readContent = File.ReadAllText(_testFilename);
        Assert.AreEqual(content, readContent);
    }

    [Test]
    public void ReadFromFile_WhenFileExists_ReturnsCorrectContent()
    {
        string content = "This is a test.";
        _fileProcessor.WriteToFile(_testFilename, content);

        string result = _fileProcessor.ReadFromFile(_testFilename);
        Assert.AreEqual(content, result);
    }

    [Test]
    public void ReadFromFile_WhenFileDoesNotExist_ThrowsIOException()
    {
        string nonExistentFile = "nonexistentfile.txt";

        var ex = Assert.Throws<IOException>(() => _fileProcessor.ReadFromFile(nonExistentFile));
        Assert.AreEqual("An error occurred while reading from the file.", ex.Message);
    }

    [Test]
    public void WriteToFile_WhenIOExceptionOccurs_ThrowsIOException()
    {
        string content = "Content that causes error.";
        string invalidFilename = "/invalidPath/testfile.txt";  // Example of invalid path

        var ex = Assert.Throws<IOException>(() => _fileProcessor.WriteToFile(invalidFilename, content));
        Assert.AreEqual("An error occurred while writing to the file.", ex.Message);
    }
}
