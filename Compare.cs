using System;
using System.Collections.Generic;

    class Compare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements for Set1 separate by space:");
            HashSet<int> set1 = GetSetFromInput();

            Console.WriteLine("Enter elements for Set2 separate by space:");
            HashSet<int> set2 = GetSetFromInput();

            bool areEqual = AreSetsEqual(set1, set2);

            Console.WriteLine("Are the sets equal? " + areEqual);
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

        static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
        {
            if (set1.Count != set2.Count)
            {
                return false; 
            }

            foreach (var item in set1)
            {
                if (!set2.Contains(item))
                {
                    return false; 
                }
            }

            return true; 
        }
    }
