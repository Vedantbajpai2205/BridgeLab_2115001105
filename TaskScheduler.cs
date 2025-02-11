using System;

class Task
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public Task Next;
}

class TaskScheduler
{
    Task head;

    public void AddAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task
        {
            TaskID = taskID,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate
        };

        if (head == null)
        {
            head = newTask;
            newTask.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
            head = newTask;
        }
    }

    public void AddAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task
        {
            TaskID = taskID,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate
        };

        if (head == null)
        {
            head = newTask;
            newTask.Next = head;  
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
    }

    public void AddAtPosition(int taskID, string taskName, int priority, DateTime dueDate, int position)
    {
        Task newTask = new Task
        {
            TaskID = taskID,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate
        };

        if (position == 0)
        {
            AddAtBeginning(taskID, taskName, priority, dueDate);
            return;
        }

        Task temp = head;
        for (int i = 0; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp != null)
        {
            newTask.Next = temp.Next;
            temp.Next = newTask;
        }
    }

    public void RemoveByTaskID(int taskID)
    {
        if (head == null) return;

        if (head.TaskID == taskID)
        {
            if (head.Next == head)  
            {
                head = null;
            }
            else
            {
                Task temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = head.Next;
                head = head.Next;
            }
            return;
        }

        Task current = head;
        Task previous = null;

        do
        {
            if (current.TaskID == taskID)
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                }
                return;
            }
            previous = current;
            current = current.Next;
        } while (current != head);
    }

    public void ViewAndMoveNext()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Task temp = head;
        Console.WriteLine("Current Task - Task ID: " + temp.TaskID + ", Task Name: " + temp.TaskName + ", Priority: " + temp.Priority + ", Due Date: " + temp.DueDate.ToShortDateString());
        head = head.Next;
    }

    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Task temp = head;
        do
        {
            Console.WriteLine("Task ID: " + temp.TaskID + ", Task Name: " + temp.TaskName + ", Priority: " + temp.Priority + ", Due Date: " + temp.DueDate.ToShortDateString());
            temp = temp.Next;
        } while (temp != head);
    }

    public Task SearchByPriority(int priority)
    {
        if (head == null)
        {
            return null;
        }

        Task temp = head;
        do
        {
            if (temp.Priority == priority)
            {
                return temp;
            }
            temp = temp.Next;
        } while (temp != head);

        return null;
    }
    static void Main(string[] args)
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddAtBeginning(1, "Task A", 3, new DateTime(2025, 2, 15));
        scheduler.AddAtEnd(2, "Task B", 2, new DateTime(2025, 3, 10));
        scheduler.AddAtEnd(3, "Task C", 1, new DateTime(2025, 2, 20));
        scheduler.AddAtPosition(4, "Task D", 4, new DateTime(2025, 4, 5), 2);

        Console.WriteLine("All tasks:");
        scheduler.DisplayAllTasks();

        scheduler.ViewAndMoveNext();
        scheduler.ViewAndMoveNext();

        scheduler.RemoveByTaskID(2);
        Console.WriteLine("After removing Task ID 2:");
        scheduler.DisplayAllTasks();

        Task foundTask = scheduler.SearchByPriority(3);
        if (foundTask != null)
        {
            Console.WriteLine("Found Task by Priority 3: Task ID: " + foundTask.TaskID + ", Task Name: " + foundTask.TaskName + ", Due Date: " + foundTask.DueDate.ToShortDateString());
        }
        else
        {
            Console.WriteLine("No task found with the given priority.");
        }
    }
}
