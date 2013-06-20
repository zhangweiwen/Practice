namespace Builder
{
    /// <summary>
    /// 具体建造者类,这里是重写定义的属性,或者像下面这样在Build方法实现对产品的构建
    /// 这里是真正完成构建的地方
    /// </summary>
    public sealed class CayenneBuilder : CarBuilder
    {
        private readonly Car _car;

        public CayenneBuilder()
        {
            _car = new Car("保时捷2013款卡宴Turbo S", 2630000D);
        }

        public override void Build()
        {
            _car.Add("发动机 => 4.8T 551马力 V8");
            _car.Add("变速箱 => 8挡手自一体");
            _car.Add("安全气囊 => 全");
            _car.Add("ABS防抱死");
            _car.Add("电动天窗");
            _car.Add("全景天窗");
            _car.Add("前/后驻车雷达");
            _car.Add("GPS导航系统");
            _car.Add("氙气大灯");
        }

        public override Car GetCar()
        {
            return _car;
        }
    }
}