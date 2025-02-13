using System;
using System.Collections.Generic;

public class QueueUsingStacks<T>
{
    private Stack<T> stackEnqueue;
    private Stack<T> stackDequeue;

    public QueueUsingStacks()
    {
        stackEnqueue = new Stack<T>();
        stackDequeue = new Stack<T>();
    }

    public void Enqueue(T item)
    {
        stackEnqueue.Push(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        if (stackDequeue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }

        return stackDequeue.Pop();
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        if (stackDequeue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }

        return stackDequeue.Peek();
    }

    public bool IsEmpty()
    {
        return stackEnqueue.Count == 0 && stackDequeue.Count == 0;
    }
}

public class Stack1
{
    public static void Main()
    {
        QueueUsingStacks<int> queue = new QueueUsingStacks<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Peek());   
        Console.WriteLine(queue.Dequeue()); 
        queue.Enqueue(4);
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 
    }
}