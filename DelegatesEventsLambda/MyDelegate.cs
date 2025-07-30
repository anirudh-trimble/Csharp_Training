using System;

namespace DelegatesEventsLambda
{
    public delegate int MathOperation(int a, int b);

    public class MyDelegate
    {
        public static int Add(int x, int y) => x + y;
        public static int Multiply(int x, int y) => x * y;

        public static void Run()
        {
            MathOperation operation;

            operation = Add;
            Console.WriteLine("Add: " + operation(5, 3));

            operation = Multiply;
            Console.WriteLine("Multiply: " + operation(5, 3));
        }
    }
}
