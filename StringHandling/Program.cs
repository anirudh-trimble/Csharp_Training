using System;

class StringHandlingDemo
{
    static void Main(string[] args)
    {
        string str1 = "  Hello ";
        string str2 = "World!";

        // Concatenation
        string result = str1 + str2;
        Console.WriteLine("Concatenation: " + result);

        // Trim
        string trimmed = str1.Trim();
        Console.WriteLine("Trimmed str1: '" + trimmed + "'");

        // ToUpper / ToLower
        Console.WriteLine("Uppercase: " + str2.ToUpper());
        Console.WriteLine("Lowercase: " + str2.ToLower());

        // Length
        Console.WriteLine("Length of str2: " + str2.Length);

        // Substring
        Console.WriteLine("Substring of str2: " + str2.Substring(0, 3));

        // Replace
        Console.WriteLine("Replace 'o' with 'x' in str2: " + str2.Replace('o', 'x'));

        // Contains
        Console.WriteLine("Does str2 contain 'rld'? " + str2.Contains("rld"));

        // IndexOf
        Console.WriteLine("Index of 'W' in str2: " + str2.IndexOf('W'));

        // String interpolation
        string name = "Anirudh";
        Console.WriteLine($"Hello, {name}! Welcome.");

        // Split
        string sentence = "C# is powerful and modern";
        string[] words = sentence.Split(' ');
        Console.WriteLine("Words in sentence:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Compare
        string a = "apple";
        string b = "Apple";
        Console.WriteLine("Compare a & b (case-sensitive): " + string.Compare(a, b)); // > 0
        Console.WriteLine("Compare a & b (ignore case): " + string.Compare(a, b, true)); // 0

        // String.Join
        string joined = string.Join("-", words);
        Console.WriteLine("Joined words with '-': " + joined);
    }
}
