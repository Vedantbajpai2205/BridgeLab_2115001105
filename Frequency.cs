using System;
using System.Collections.Generic;

    class Frequency
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string> { "apple", "banana", "apple", "orange" , "orange" , "Mango"};
            Dictionary<string, int> frequency = CountFrequency(inputList);

            foreach (var item in frequency)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }

        static Dictionary<string, int> CountFrequency(List<string> list)
        {
            Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

            foreach (var item in list)
            {
                if (frequencyDict.ContainsKey(item))
                {
                    frequencyDict[item]++;
                }
                else
                {
                    frequencyDict[item] = 1;
                }
            }

            return frequencyDict;
        }
    }
