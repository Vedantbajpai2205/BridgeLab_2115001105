using NUnit.Framework;

[TestFixture]
public class TaskRunnerTests
{
    private TaskRunner _taskRunner;

    [SetUp]
    public void SetUp()
    {
        _taskRunner = new TaskRunner();
    }

    [Test]
    [Timeout(2000)]
    public void LongRunningTask_WhenExecuted_TimesOutIfMoreThanTwoSeconds()
    {
        _taskRunner.LongRunningTask();
    }
}
