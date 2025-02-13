using System;
using System.Collections.Generic;

class StockSpan
{
    public static void CalculateSpan(int[] prices, int n)
    {
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            span[i] = (stack.Count == 0) ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(span[i] + " ");
        }
    }

    static void Main()
    {
        int[] prices = { 95, 80, 66, 77, 63, 76, 88 };
        int n = prices.Length;

        CalculateSpan(prices, n);
    }
}
