namespace Builder
{
    /// <summary>
    /// 具体建造者类,这里是重写定义的属性,或者像下面这样在Build方法实现对产品的构建
    /// 这里是真正完成构建的地方
    /// </summary>
    public sealed class QQCarBuilder : CarBuilder
    {
        private readonly Car _car;

        public QQCarBuilder()
        {
            _car = new Car("奇瑞2013款QQ乞丐版", 31000D);
        }

        public override void Build()
        {
            _car.Add("发动机 => 1.0L 69马力 L3");
            _car.Add("变速箱 => 5挡手动");
        }

        public override Car GetCar()
        {
            return _car;
        }
    }
}