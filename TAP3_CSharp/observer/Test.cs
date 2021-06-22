using System;

namespace observer
{
    class Test
    {
        public static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.Attach(new HexaObserver());
            subject.Attach(new OctalObserver());
            subject.Attach(new BinaryObserver());
            Console.WriteLine("First state change: 15");
            subject.SetState(15);
            Console.WriteLine("Second state change: 10");
            subject.SetState(10);
        }
    }
}
