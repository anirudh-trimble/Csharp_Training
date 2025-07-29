using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;  // May throw DivideByZeroException
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed (finally block).");
            }

            Console.WriteLine("Program continues...");
        }
    }
}
