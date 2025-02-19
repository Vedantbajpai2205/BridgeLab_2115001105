using System;
using System.Collections.Generic;

    class Binary
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<string> binaryQueue = GenerateBinaryNumbers(N);
            foreach (var binary in binaryQueue)
            {
                Console.WriteLine(binary);
            }
        }

        static Queue<string> GenerateBinaryNumbers(int N)
        {
            Queue<string> binaryQueue = new Queue<string>();
            binaryQueue.Enqueue("1");
            List<string> result = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string currentBinary = binaryQueue.Dequeue();
                result.Add(currentBinary);
                binaryQueue.Enqueue(currentBinary + "0");
                binaryQueue.Enqueue(currentBinary + "1");
            }
            return new Queue<string>(result);
        }
    }
