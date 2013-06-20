using System;

namespace Adapter
{
    /// <summary>
    /// 变压器种类A,能将220V转为110V
    /// 这是适配器,继承目标,传入要被适配的类
    /// </summary>
    public sealed class TransformerA : IPower
    {
        private readonly ChinaPower _source;

        public TransformerA(ChinaPower source)
        {
            if (source == null)
                throw new ArgumentException("source");

            _source = source;
        }

        public int Supply110()
        {
            return _source.Supply220() - 110;
        }
    }
}