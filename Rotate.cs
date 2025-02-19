using System;
using System.Collections.Generic;

    class Rotate
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int> { 10, 20, 30, 40, 50 };
            int positions = 2;

            List<int> rotatedList = RotateList(inputList, positions);

            Console.WriteLine("Rotated List: ");
            foreach (var item in rotatedList)
            {
                Console.Write(item + " ");
            }
        }

        static List<int> RotateList(List<int> list, int positions)
        {
            int count = list.Count;
            positions = positions % count;  
            List<int> rotatedList = new List<int>();

            for (int i = positions; i < count; i++)
            {
                rotatedList.Add(list[i]);
            }
            for (int i = 0; i < positions; i++)
            {
                rotatedList.Add(list[i]);
            }

            return rotatedList;
        }
    }

