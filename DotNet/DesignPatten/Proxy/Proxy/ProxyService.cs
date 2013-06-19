namespace Proxy
{
    public sealed class ProxyService : IService
    {
        private readonly WcfService _service = new WcfService();

        public void Method1()
        {
            _service.Method1();
        }

        public void Method2()
        {
            _service.Method2();
        }
    }
}