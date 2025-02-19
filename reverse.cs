using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseList
{
    class Reverse
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("ArrayList: ");
            PrintList(arrayList);

            ReverseArrayList(arrayList);

            Console.WriteLine("Reversed ArrayList: ");
            PrintList(arrayList);

            LinkedList<int> linkedList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("LinkedList: ");
            PrintLinkedList(linkedList);

            ReverseLinkedList(linkedList);

            Console.WriteLine("Reversed LinkedList: ");
            PrintLinkedList(linkedList);
        }

        static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;
            while (start < end)
            {
                var temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
        }
        static void PrintLinkedList(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void ReverseLinkedList(LinkedList<int> list)
        {
            LinkedListNode<int> current = list.First;
            LinkedList<int> reversedList = new LinkedList<int>();

            while (current != null)
            {
                reversedList.AddFirst(current.Value);
                current = current.Next;
            }

            list.Clear();
            foreach (var item in reversedList)
            {
                list.AddLast(item);
            }
        }
    }
}
