using System;

public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

class Program
{
    static void Main()
    {
        string message = "Hello from the other side.";
        Console.WriteLine(message.WordCount());  // Output: 5
    }
}
