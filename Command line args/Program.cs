using System;
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No arguments were passed.");
        }
        else
        {
            Console.WriteLine($"Number of arguments: {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1}: {args[i]}");
            }

            // convert first 2 arguments to integers and add them
            if (args.Length >= 2)
            {
                if (int.TryParse(args[0], out int num1) && int.TryParse(args[1], out int num2))
                {
                    Console.WriteLine($"Sum: {num1 + num2}");
                }
                else
                {
                    Console.WriteLine("To calculate sum, enter first two arguments as numbers.");
                }
            }
        }
    }
}
