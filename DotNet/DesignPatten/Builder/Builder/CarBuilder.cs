namespace Builder
{
    /// <summary>
    /// 建造者的抽象类,可以定义一堆属性对应产品类,也可以像下面这样只有一个Build方法
    /// 还一定需要一个获取产品类实例的方法或者属性
    /// </summary>
    public abstract class CarBuilder
    {
        public abstract void Build();

        public abstract Car GetCar();
    }
}