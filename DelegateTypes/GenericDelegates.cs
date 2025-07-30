using System;

namespace DelegatesDemo
{
    public class GenericDelegates
    {
        public static void Run()
        {
            // Action: returns void, takes parameters
            Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
            greet("Anirudh");

            // Func: returns a value, can take parameters
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Sum of 3 and 4: {add(3, 4)}");

            // Predicate: returns bool, takes one parameter
            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine($"Is 6 even? {isEven(6)}");
        }
    }
}
