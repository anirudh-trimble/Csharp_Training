using System;
using System.Collections.Generic;

namespace GenericCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. List<T> – dynamic array
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");

            Console.WriteLine("List<T> Example:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();

            // 2. Dictionary<TKey, TValue> – key-value pairs
            Dictionary<int, string> studentMap = new Dictionary<int, string>();
            studentMap.Add(1, "Anirudh");
            studentMap.Add(2, "krish");
            studentMap.Add(3, "s");

            Console.WriteLine("Dictionary<TKey, TValue> Example:");
            foreach (var kvp in studentMap)
            {
                Console.WriteLine($"Roll No: {kvp.Key}, Name: {kvp.Value}");
            }

            Console.WriteLine();

            // 3. HashSet<T> – stores only unique elements
            HashSet<int> uniqueNumbers = new HashSet<int>();
            uniqueNumbers.Add(10);
            uniqueNumbers.Add(20);
            uniqueNumbers.Add(10); // Duplicate, will be ignored
            uniqueNumbers.Add(5);

            Console.WriteLine("HashSet<T> Example:");
            foreach (var num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
