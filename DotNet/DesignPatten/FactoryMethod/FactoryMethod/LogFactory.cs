namespace FactoryMethod
{
    /// <summary>
    /// 工厂方法与简单工厂的区别就是连工厂类也搞过抽象出来继承一下
    /// 如果创建逻辑复杂的话,可以使用工厂方法
    /// </summary>
    public abstract class LogFactory
    {
        public abstract Log Create();
    }
}