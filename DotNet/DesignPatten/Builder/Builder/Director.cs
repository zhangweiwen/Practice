namespace Builder
{
    /// <summary>
    /// 指挥者类,这里的演示太简单,真正应该根据用户的需要去指挥Builder类怎样完成构建
    /// </summary>
    public sealed class Director
    {
        public void Construct(CarBuilder builder)
        {
            builder.Build();
        }
    }
}