using System.ComponentModel;

namespace Events
{
    public class MyClass
    {
        protected EventHandlerList _subs;

        public event EventHandler SomeEvent
        {
            add
            {
                _subs.AddHandler(this, value);
            }
            remove
            {
                _subs.RemoveHandler(this, value);
            }
        }

    }

    public class MyCustomEventArgs : EventArgs
    {
        public int Count { set; get; }
    }

    public class Events
    {
        private int count = 0;

        public event EventHandler<MyCustomEventArgs> onCountIncrement;
        public event EventHandler<MyCustomEventArgs> onCountDecrement;

        public EventHandler onSomething;

        public int Count { get => count; }

        public Events()
        {
        }

        public void Increment()
        {
            count++;
            if (onCountIncrement != null)
            {
                onCountIncrement(this, new MyCustomEventArgs { Count = count });
            }
        }

        public void Decrement()
        {
            count--;
            if (onCountDecrement != null)
            {
                onCountDecrement(this, new MyCustomEventArgs { Count = count });
            }
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            Events events = new Events();
            System.Console.WriteLine(events.Count);
            events.onCountIncrement += PrintIncrement;
            events.onCountIncrement += PrintIncrement;
            events.onCountIncrement -= null;
            events.onCountDecrement += PrintDecrement;


            events.Increment();
            events.Increment();
            events.Decrement();
            events.onCountDecrement -= PrintDecrement;
            events.Decrement();
        }

        public static void PrintIncrement(object sender, MyCustomEventArgs e)
        {
            System.Console.WriteLine($"Incremented now count is: {e.Count}");
        }

        public static void PrintDecrement(object sender, MyCustomEventArgs e)
        {
            System.Console.WriteLine($"Decremented now count is: {e.Count}");
        }
    }
}
