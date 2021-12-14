using System;

namespace FluentEmail
{
    public class DeNotifier : INotifier
    {
        public void Notify()
        {
            Console.WriteLine("I am DeNotifier");
        }
    }
}

