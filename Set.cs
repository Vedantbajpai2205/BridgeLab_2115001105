using System;
using System.Collections.Generic;

    class Set
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements for Set1 separate by space:");
            HashSet<int> set1 = GetSetFromInput();

            Console.WriteLine("Enter elements for Set2 separate by space:");
            HashSet<int> set2 = GetSetFromInput();

            HashSet<int> union = UnionOfSets(set1, set2);
            HashSet<int> intersection = IntersectionOfSets(set1, set2);

            Console.WriteLine("Union: {" + string.Join(", ", union) + "}");
            Console.WriteLine("Intersection: {" + string.Join(", ", intersection) + "}");
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

        static HashSet<int> UnionOfSets(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2); 
            return union;
        }

        static HashSet<int> IntersectionOfSets(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> intersection = new HashSet<int>(set1);
            intersection.IntersectWith(set2); 
            return intersection;
        }
    }
