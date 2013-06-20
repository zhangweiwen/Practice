namespace CommandPattern
{
    /// <summary>
    /// 烤鸡命令.调用Receiver的烤鸡方法
    /// </summary>
    public sealed class ChickenCommand : Command
    {
        public ChickenCommand(Chef chef)
            : base(chef)
        {
        }

        public override void Excute()
        {
            Chef.CookChicken();
        }
    }
}