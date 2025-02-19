using System;
using System.Collections.Generic;

    class Symmetric
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements for Set1 separate by space:");
            HashSet<int> set1 = GetSetFromInput();

            Console.WriteLine("Enter elements for Set2 separate by space:");
            HashSet<int> set2 = GetSetFromInput();

            HashSet<int> symmetricDifference = SymmetricDifferenceOfSets(set1, set2);

            Console.WriteLine("Symmetric Difference: {" + string.Join(", ", symmetricDifference) + "}");
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

        static HashSet<int> SymmetricDifferenceOfSets(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> symmetricDifference = new HashSet<int>();

            foreach (var item in set1)
            {
                if (!set2.Contains(item))
                {
                    symmetricDifference.Add(item);
                }
            }

            foreach (var item in set2)
            {
                if (!set1.Contains(item))
                {
                    symmetricDifference.Add(item);
                }
            }

            return symmetricDifference;
        }
    }
