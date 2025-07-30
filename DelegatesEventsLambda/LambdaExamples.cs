using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesEventsLambda
{
    public class LambdaExamples
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Use lambda to filter
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("Even numbers:");
            evenNumbers.ForEach(n => Console.WriteLine(n));

            // Lambda as anonymous method
            Func<int, int, int> subtract = (a, b) => a - b;
            Console.WriteLine("Subtract 7 - 3 = " + subtract(7, 3));
        }
    }
}
