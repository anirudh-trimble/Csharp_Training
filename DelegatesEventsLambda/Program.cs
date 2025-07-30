using System;

namespace DelegatesEventsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Delegate Demo ===");
            MyDelegate.Run();

            Console.WriteLine("\n=== Event Demo ===");
            var publisher = new MyEventPublisher();
            var subscriber = new MyEventSubscriber(publisher);
            publisher.TriggerEvent();

            Console.WriteLine("\n=== Lambda Demo ===");
            LambdaExamples.Run();
        }
    }
}
