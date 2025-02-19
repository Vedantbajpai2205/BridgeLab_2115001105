using System;
using System.Collections.Generic;

    class Sorted
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements for the set separate by space:");
            HashSet<int> set = GetSetFromInput();

            List<int> sortedList = ConvertSetToSortedList(set);

            Console.WriteLine("Sorted List: [" + string.Join(", ", sortedList) + "]");
        }

        static HashSet<int> GetSetFromInput()
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            HashSet<int> set = new HashSet<int>();

            foreach (string element in elements)
            {
                if (int.TryParse(element, out int value))
                {
                    set.Add(value);
                }
                else
                {
                    Console.WriteLine("Invalid input: " + element + " is not a valid integer.");
                }
            }

            return set;
        }

        static List<int> ConvertSetToSortedList(HashSet<int> set)
        {
            List<int> sortedList = new List<int>(set);
            
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                for (int j = 0; j < sortedList.Count - 1 - i; j++)
                {
                    if (sortedList[j] > sortedList[j + 1])
                    {
                        // Swap 
                        int temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }

            return sortedList;
        }
    }
