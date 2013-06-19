using System;

namespace Proxy
{
    /// <summary>
    /// 实际做事情的类
    /// </summary>
    public sealed class WcfService : IService
    {
        public void Method1()
        {
            Console.WriteLine("Calling Method1()...");
        }

        public void Method2()
        {
            Console.WriteLine("Calling Method2()...");
        }
    }
}