using System;

namespace DelegatesEventsLambda
{
    public class MyEventPublisher
    {
        public event EventHandler MyEvent;

        public void TriggerEvent()
        {
            Console.WriteLine("Triggering the event...");
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
