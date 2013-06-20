namespace Adapter
{
    /// <summary>
    /// 这些通常为第三方组件,不能变,又不适合自己用
    /// 所以要使用适配器
    /// </summary>
    public sealed class ChinaPower
    {
        public int Supply220()
        {
            return 220;
        }
    }
}