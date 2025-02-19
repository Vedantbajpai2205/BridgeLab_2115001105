using System;
using System.Collections.Generic;

    class QueueReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements for the queue separate by space:");
            Queue<int> queue = GetQueueFromInput();

            Console.WriteLine("Original Queue: [" + string.Join(", ", queue) + "]");

            ReverseQueue(queue);

            Console.WriteLine("Reversed Queue: [" + string.Join(", ", queue) + "]");
        }

        static Queue<int> GetQueueFromInput()
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            Queue<int> queue = new Queue<int>();

            foreach (string element in elements)
            {
                queue.Enqueue(int.Parse(element)); 
            }

            return queue;
        }

        static void ReverseQueue(Queue<int> queue)
        {
            if (queue.Count == 0)
                return;

            int item = queue.Dequeue();

            ReverseQueue(queue);

            queue.Enqueue(item);
        }
    }
