namespace Decorator
{
    /// <summary>
    /// 模拟Asp.Net Mvc的Action Filter功能
    /// 这是需要被装饰的类的抽象
    /// 注意这是抽象,不是真正被装饰的类
    /// </summary>
    public abstract class Controller
    {
        /// <summary>
        /// 这是需要被装饰的方法,装饰的是方法,不是给类添加一个功能
        /// 装饰后这个类的功能还是只有一个(Action)
        /// </summary>
        public abstract void Action();
    }
}