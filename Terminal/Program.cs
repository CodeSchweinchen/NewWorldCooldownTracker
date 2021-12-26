using NewWorldCooldownTracker;
using System;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");
            var tracker = new Tracker(new ConsoleLogger());
        }
    }
}
