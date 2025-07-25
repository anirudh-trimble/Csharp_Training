class Program
{
    // User-defined function: Adds two numbers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Call by Value: Original 'x' in Main remains unchanged
    static void SquareByValue(int x)
    {
        x = x * x;
        Console.WriteLine("Inside SquareByValue: " + x);
    }

    // Call by Reference using 'ref': Changes reflected in Main
    static void SquareByRef(ref int x)
    {
        x = x * x;
        Console.WriteLine("Inside SquareByRef: " + x);
    }

    // Call by Reference using 'out': Assigns output values
    static void GetMinMax(int a, int b, out int min, out int max)
    {
        min = (a < b) ? a : b;
        max = (a > b) ? a : b;
    }

    static void Main()
    {
        int sum = Add(10, 20);
        Console.WriteLine("Sum: " + sum);

        int val1 = 5;
        SquareByValue(val1);
        Console.WriteLine("After SquareByValue: " + val1);

        int val2 = 5;
        SquareByRef(ref val2);
        Console.WriteLine("After SquareByRef: " + val2);

        int num1 = 10, num2 = 30;
        int min, max;
        GetMinMax(num1, num2, out min, out max);
        Console.WriteLine($"Min: {min}, Max: {max}");
    }
}
