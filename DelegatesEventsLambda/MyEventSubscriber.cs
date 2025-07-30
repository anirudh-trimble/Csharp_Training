using System;

namespace DelegatesEventsLambda
{
    public class MyEventSubscriber
    {
        public MyEventSubscriber(MyEventPublisher publisher)
        {
            publisher.MyEvent += HandleEvent;
        }

        private void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event received and handled!");
        }
    }
}
