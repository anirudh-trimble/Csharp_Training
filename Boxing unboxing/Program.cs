using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 42;

        // Boxing
        object boxedNumber = number;

        Console.WriteLine("Boxed value: " + boxedNumber);

        // Unboxing
        int unboxedNumber = (int)boxedNumber;

        Console.WriteLine("Unboxed value: " + unboxedNumber);

        // Changing original value to show they're independent
        number = 100;
        Console.WriteLine("Original value after change: " + number);
        Console.WriteLine("Boxed value remains: " + boxedNumber);
    }
}
