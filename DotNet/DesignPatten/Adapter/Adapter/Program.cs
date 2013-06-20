namespace Adapter
{
    /// <summary>
    /// 适配器模式
    /// 第三方接口不能变,又不适合自己使用
    /// 就使用适配器继承自己的接口,在适配器里调用把第三方接口,就是适配
    /// </summary>
    class Program
    {
        static void Main()
        {

            var chinaPower = new ChinaPower();
            var transformerA = new TransformerA(chinaPower);
            var light = new Light(transformerA);
            light.Up();
        }
    }
}