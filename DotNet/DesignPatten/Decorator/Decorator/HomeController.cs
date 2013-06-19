using System;

namespace Decorator
{
    /// <summary>
    /// 这是需要被装饰的类
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 这是需要被装饰的方法
        /// </summary>
        public override void Action()
        {
            Console.WriteLine("open http://192.168.1.100/someweb/admin");
        }
    }
}