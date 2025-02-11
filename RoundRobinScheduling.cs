using System;

class Process
{
    public int ProcessID;
    public int BurstTime;
    public int RemainingBurstTime;
    public int Priority;
    public Process Next;
}

class RoundRobinScheduling
{
    private Process head;
    private Process tail;
    private int totalProcesses;

    public void AddProcess(int processID, int burstTime, int priority)
    {
        Process newProcess = new Process
        {
            ProcessID = processID,
            BurstTime = burstTime,
            RemainingBurstTime = burstTime,
            Priority = priority,
            Next = null
        };

        if (head == null)
        {
            head = tail = newProcess;
            newProcess.Next = head; 
        }
        else
        {
            tail.Next = newProcess;
            tail = newProcess;
            tail.Next = head; 
        }
        totalProcesses++;
    }

    public void RemoveProcess(int processID)
    {
        if (head == null) return;

        Process temp = head;
        Process prev = null;

        if (head.ProcessID == processID)
        {
            if (head == head.Next) 
            {
                head = null;
            }
            else
            {
                tail.Next = head.Next;
                head = head.Next;
            }
            totalProcesses--;
            return;
        }

        do
        {
            prev = temp;
            temp = temp.Next;
            if (temp.ProcessID == processID)
            {
                prev.Next = temp.Next;
                if (temp == tail)
                {
                    tail = prev;
                }
                totalProcesses--;
                return;
            }
        } while (temp != head);
    }

    public void SimulateRoundRobin(int timeQuantum)
    {
        int totalWaitingTime = 0;
        int totalTurnaroundTime = 0;
        int processesCompleted = 0;

        while (processesCompleted < totalProcesses)
        {
            Process temp = head;
            bool processExecuted = false;

            do
            {
                if (temp.RemainingBurstTime > 0)
                {
                    processExecuted = true;
                    if (temp.RemainingBurstTime > timeQuantum)
                    {
                        temp.RemainingBurstTime -= timeQuantum;
                    }
                    else
                    {
                        totalWaitingTime += temp.RemainingBurstTime;
                        totalTurnaroundTime += (temp.BurstTime + totalWaitingTime);
                        temp.RemainingBurstTime = 0;
                        processesCompleted++;
                        RemoveProcess(temp.ProcessID);
                    }
                }
                temp = temp.Next;
            } while (temp != head && processExecuted);

            DisplayQueue();
        }

        double avgWaitingTime = (double)totalWaitingTime / totalProcesses;
        double avgTurnaroundTime = (double)totalTurnaroundTime / totalProcesses;

        Console.WriteLine("Average Waiting Time: " + avgWaitingTime);
        Console.WriteLine("Average Turnaround Time: " + avgTurnaroundTime);
    }

    public void DisplayQueue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Process temp = head;
        do
        {
            Console.WriteLine("Process ID: " + temp.ProcessID + ", Burst Time: " + temp.BurstTime + ", Remaining Burst Time: " + temp.RemainingBurstTime + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        RoundRobinScheduling roundRobinScheduler = new RoundRobinScheduling();

        roundRobinScheduler.AddProcess(1, 5, 3); 
        roundRobinScheduler.AddProcess(2, 3, 2); 
        roundRobinScheduler.AddProcess(3, 8, 1); 
        roundRobinScheduler.AddProcess(4, 6, 4); 

        Console.WriteLine("Initial Queue of Processes:");
        roundRobinScheduler.DisplayQueue();

        int timeQuantum = 2; 

        Console.WriteLine("Simulating Round Robin with Time Quantum: " + timeQuantum);
        roundRobinScheduler.SimulateRoundRobin(timeQuantum);
    }
}
