using System;

namespace DelegatesDemo
{
    public class AnonymousDelegates
    {
        public delegate void Printer(string message);

        public static void Run()
        {
            // Anonymous method using delegate keyword
            Printer print = delegate (string msg)
            {
                Console.WriteLine("Anonymous says: " + msg);
            };

            print("Hello from anonymous method");

            // Anonymous method using lambda
            Printer printLambda = (msg) => Console.WriteLine("Lambda says: " + msg);
            printLambda("Hello from lambda expression");
        }
    }
}
