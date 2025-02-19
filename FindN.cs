using System;
using System.Collections.Generic;


    class FindN
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            Console.WriteLine("Enter the elements of the list separate with space: ");
            string[] elements = Console.ReadLine().Split(' ');

            foreach (string element in elements)
            {
                list.AddLast(element);
            }

            Console.Write("Enter the value of N  (Nth) element from the end: ");
            int N = int.Parse(Console.ReadLine());

            string result = FindNthFromEnd(list, N);

            if (result != null)
            {
                Console.WriteLine("The " + N + "th element from the end is:  " + result);
            }
            else
            {
                Console.WriteLine("Invalid input: " + N + " is larger than the size of the list.");
            }
        }

        static string FindNthFromEnd(LinkedList<string> list, int N)
        {
            LinkedListNode<string> firstPointer = list.First;
            LinkedListNode<string> secondPointer = list.First;

            for (int i = 0; i < N; i++)
            {
                if (firstPointer == null) return null;
                firstPointer = firstPointer.Next;
            }

            while (firstPointer != null)
            {
                firstPointer = firstPointer.Next;
                secondPointer = secondPointer.Next;
            }

            return secondPointer.Value;
        }
    }
