using System;
using System.Collections.Generic;

class StackSort
{
    // Main function to sort stack
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count == 0)
        {
            return; 
        }

        int topElement = stack.Pop();

        SortStack(stack);

        InsertInSortedOrder(stack, topElement);
    }

    public static void InsertInSortedOrder(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element); 
            return;
        }

        int top = stack.Pop();
        InsertInSortedOrder(stack, element);

        stack.Push(top);
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        
        stack.Push(24);
        stack.Push(3);
        stack.Push(45);
        stack.Push(89);
        stack.Push(92);
        stack.Push(28);

        Console.WriteLine("Original Stack: ");
        PrintStack(stack);

        SortStack(stack);

        Console.WriteLine("Sorted Stack: ");
        PrintStack(stack);
    }

    static void PrintStack(Stack<int> stack)
    {
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
