using System;

namespace StaticClassDemo
{
    // Static class
    public static class MathUtility
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int sum = MathUtility.Add(10, 5);
            int product = MathUtility.Multiply(4, 3);
            double root = MathUtility.SquareRoot(49);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Square Root: {root}");
        }
    }
}
