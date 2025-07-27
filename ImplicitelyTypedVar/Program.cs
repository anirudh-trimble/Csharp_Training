using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Using var with different types
        var number = 10;               // inferred as int
        var message = "Hello, C#!";    // inferred as string
        var price = 99.99;             // inferred as double
        var isValid = true;            // inferred as bool

        Console.WriteLine("number: " + number);
        Console.WriteLine("message: " + message);
        Console.WriteLine("price: " + price);
        Console.WriteLine("isValid: " + isValid);

        // Using var with a list
        var names = new List<string> { "Alice", "Bob", "Charlie" };
        foreach (var name in names)
        {
            Console.WriteLine("Name: " + name);
        }

        // Compile-time type is fixed
        // number = "Ten"; // Error: cannot assign string to an int variable
    }
}
