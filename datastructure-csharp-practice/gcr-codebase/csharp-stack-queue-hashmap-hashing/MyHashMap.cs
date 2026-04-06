using System;
using System.Collections.Generic;

class MyHashMap
{
    // Size of hash table
    private int size = 10;

    // Array of linked lists (buckets)
    private LinkedList<KeyValuePair<int, int>>[] buckets;

    public MyHashMap()
    {
        buckets = new LinkedList<KeyValuePair<int, int>>[size];

        // Initialize each bucket
        for (int i = 0; i < size; i++)
        {
            buckets[i] = new LinkedList<KeyValuePair<int, int>>();
        }
    }

    // Hash function
    private int GetIndex(int key)
    {
        return key % size;
    }

    // Insert or update key-value pair
    public void Put(int key, int value)
    {
        int index = GetIndex(key);

        foreach (var pair in buckets[index])
        {
            if (pair.Key == key)
            {
                // Update existing value
                buckets[index].Remove(pair);
                buckets[index].AddLast(new KeyValuePair<int, int>(key, value));
                return;
            }
        }

        // Add new key-value pair
        buckets[index].AddLast(new KeyValuePair<int, int>(key, value));
    }

    // Retrieve value by key
    public int Get(int key)
    {
        int index = GetIndex(key);

        foreach (var pair in buckets[index])
        {
            if (pair.Key == key)
            {
                return pair.Value;
            }
        }

        // Key not found
        return -1;
    }

    // Remove key-value pair
    public void Remove(int key)
    {
        int index = GetIndex(key);

        foreach (var pair in buckets[index])
        {
            if (pair.Key == key)
            {
                buckets[index].Remove(pair);
                return;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyHashMap map = new MyHashMap();

        map.Put(1, 10);
        map.Put(2, 20);
        map.Put(12, 120);  // Collision with key 2

        Console.WriteLine("Value for key 1: " + map.Get(1));
        Console.WriteLine("Value for key 2: " + map.Get(2));
        Console.WriteLine("Value for key 12: " + map.Get(12));

        map.Remove(2);
        Console.WriteLine("Value for key 2 after removal: " + map.Get(2));
    }
}
