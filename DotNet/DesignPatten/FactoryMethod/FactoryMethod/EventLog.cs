using System;

namespace FactoryMethod
{
    public sealed class EventLog : Log
    {
        public override void Info(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg) == false)
                Console.WriteLine("Event=> Info: {0}", msg);
        }

        public override void Error(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg) == false)
                Console.WriteLine("Event=> Error: {0}", msg);
        }
    }
}