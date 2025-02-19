using System;
using System.Collections.Generic;

    class Remove
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int> { 3, 1, 2, 2, 3, 4 };
            List<int> result = RemoveDuplicates(inputList);

            Console.WriteLine("List after removing duplicates: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        static List<int> RemoveDuplicates(List<int> list)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> uniqueList = new List<int>();

            foreach (var item in list)
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    uniqueList.Add(item);
                }
            }

            return uniqueList;
        }
    }
