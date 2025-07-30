using System;

namespace DelegatesDemo
{
    public delegate void Notify();  // Custom delegate

    public class MulticastDelegates
    {
        static void MethodA() => Console.WriteLine("Method A called");
        static void MethodB() => Console.WriteLine("Method B called");

        public static void Run()
        {
            Notify notifier = MethodA;
            notifier += MethodB;
            notifier += MethodA;

            Console.WriteLine("Invoking Multicast Delegate:");
            notifier();  // All methods will be called in order
        }
    }
}
