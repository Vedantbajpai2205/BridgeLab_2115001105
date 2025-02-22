public class TaskRunner
{
    public string LongRunningTask()
    {
        System.Threading.Thread.Sleep(3000);
        return "Task Completed";
    }
}
