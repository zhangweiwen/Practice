using System;

namespace Adapter
{
    /// <summary>
    /// 110V的点灯
    /// 这个模式为这里服务,我只要能Supply110的IPower接口,不要Supply220
    /// 但实际情况是只有ChinaPower的Supply220,这个是不能变的
    /// 所以就需要一个变压器(适配器),适配器要继承目标
    /// </summary>
    public class Light
    {
        private readonly int _voltage;

        public Light(IPower power)
        {
            if (power == null)
                throw new ArgumentNullException("power");

            _voltage = power.Supply110();
        }

        public void Up()
        {
            if (_voltage == 110)
                Console.WriteLine("点亮了!");
        }
    }
}