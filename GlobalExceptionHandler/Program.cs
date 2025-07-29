using System;

class Program
{
    static void Main(string[] args)
    {
        // Register global exception handler
        AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;

        Console.WriteLine("Application started.");

        // Deliberately throw an unhandled exception
        ThrowException();

        Console.WriteLine("This line will not be executed.");
    }

    static void ThrowException()
    {
        throw new Exception("Something went wrong!");
    }

    static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
    {
        Console.WriteLine("Global Exception Handler caught: " + ((Exception)e.ExceptionObject).Message);
    }
}
