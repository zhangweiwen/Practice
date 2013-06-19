namespace Proxy
{
    /// <summary>
    /// 代理模式主要体验在:
    /// 真实做事的WcfService在消费者代码里(就是这里)没有出现
    /// 而是使用了ProxyService
    /// 而ProxyService只不过是直接使用真实类的方法
    /// </summary>
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var proxy = new ProxyService();
            proxy.Method1();
            proxy.Method2();
        }
    }
}
