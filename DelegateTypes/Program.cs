using System;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Multicast Delegates ===");
            MulticastDelegates.Run();

            Console.WriteLine("\n=== Generic Delegates ===");
            GenericDelegates.Run();

            Console.WriteLine("\n=== Anonymous Delegates ===");
            AnonymousDelegates.Run();
        }
    }
}
