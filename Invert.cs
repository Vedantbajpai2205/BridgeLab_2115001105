using System;
using System.Collections.Generic;

    class Invert
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> originalDict = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

            Dictionary<int, List<string>> invertedDict = InvertDictionary(originalDict);

            Console.WriteLine("Inverted Dictionary:");
            foreach (var entry in invertedDict)
            {
                string keys = string.Join(", ", entry.Value);
                Console.WriteLine(entry.Key + ": [" + keys + "]");
            }
        }

        static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> originalDict)
        {
            Dictionary<V, List<K>> invertedDict = new Dictionary<V, List<K>>();

            foreach (var pair in originalDict)
            {
                V value = pair.Value;
                K key = pair.Key;

                if (!invertedDict.ContainsKey(value))
                {
                    invertedDict[value] = new List<K>();
                }

                invertedDict[value].Add(key);
            }

            return invertedDict;
        }
    }
