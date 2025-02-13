using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    public static void FindMaxInSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k == 0)
            return;

        Deque<int> deque = new Deque<int>();
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while (deque.Count > 0 && nums[deque.Back()] <= nums[i])
                deque.RemoveBack();

            deque.AddBack(i);

            if (deque.Front() <= i - k)
                deque.RemoveFront();

            if (i >= k - 1)
                result.Add(nums[deque.Front()]);
        }

        foreach (var item in result)
            Console.Write(item + " ");
    }

    static void Main()
    {
        int[] nums = { 1, 4, -1, -4, 6, 5, 6, 7 };
        int k = 5;

        FindMaxInSlidingWindow(nums, k);
    }
}

public class Deque<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void AddBack(T value)
    {
        list.AddLast(value);
    }

    public void RemoveBack()
    {
        list.RemoveLast();
    }

    public void AddFront(T value)
    {
        list.AddFirst(value);
    }

    public void RemoveFront()
    {
        list.RemoveFirst();
    }

    public T Front()
    {
        return list.First.Value;
    }

    public T Back()
    {
        return list.Last.Value;
    }

    public int Count
    {
        get { return list.Count; }
    }
}
