using System;
using System.Collections.Generic;

class CustomHashMap
{
    private LinkedList<KeyValuePair<int, int>>[] table;
    private int capacity;

    public CustomHashMap(int capacity = 100)
    {
        this.capacity = capacity;
        table = new LinkedList<KeyValuePair<int, int>>[capacity];
        for (int i = 0; i < capacity; i++)
        {
            table[i] = new LinkedList<KeyValuePair<int, int>>();
        }
    }

    private int GetIndex(int key)
    {
        return key % capacity;
    }

    public void Put(int key, int value)
    {
        int index = GetIndex(key);
        LinkedList<KeyValuePair<int, int>> list = table[index];
        
        foreach (var pair in list)
        {
            if (pair.Key == key)
            {
                list.Remove(pair);
                list.AddLast(new KeyValuePair<int, int>(key, value));
                return;
            }
        }

        list.AddLast(new KeyValuePair<int, int>(key, value));
    }

    public int Get(int key)
    {
        int index = GetIndex(key);
        LinkedList<KeyValuePair<int, int>> list = table[index];
        
        foreach (var pair in list)
        {
            if (pair.Key == key)
            {
                return pair.Value;
            }
        }
        
        return 0;
    }

    public void Remove(int key)
    {
        int index = GetIndex(key);
        LinkedList<KeyValuePair<int, int>> list = table[index];
        
        foreach (var pair in list)
        {
            if (pair.Key == key)
            {
                list.Remove(pair);
                return;
            }
        }
    }

    public void PrintHashMap()
    {
        for (int i = 0; i < capacity; i++)
        {
            if (table[i].Count > 0)
            {
                Console.Write("Index " + i + ": ");
                foreach (var pair in table[i])
                {
                    Console.Write("[" + pair.Key + " = " + pair.Value + "] ");
                }
                Console.WriteLine();
            }
        }
    }
}

class Custom
{
    static void Main()
    {
        CustomHashMap hashMap = new CustomHashMap(10);

        hashMap.Put(1, 10);
        hashMap.Put(2, 20);
        hashMap.Put(11, 110);  
        hashMap.Put(3, 30);

        Console.WriteLine("Value for key 1: " + hashMap.Get(1));  
        Console.WriteLine("Value for key 2: " + hashMap.Get(2));  
        Console.WriteLine("Value for key 11: " + hashMap.Get(11)); 

      
        hashMap.Remove(2);
        Console.WriteLine("Value of key 2 after remove operation: " + hashMap.Get(2));  

        Console.WriteLine("Hash Map");
        hashMap.PrintHashMap();
    }
}
