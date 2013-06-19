using System;

namespace FactoryMethod
{
    public sealed class FileLog : Log
    {
        public override void Info(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg) == false)
                Console.WriteLine("File=> Info: {0}", msg);
        }

        public override void Error(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg) == false)
                Console.WriteLine("File=> Error: {0}", msg);
        }
    }
}