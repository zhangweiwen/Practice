namespace CommandPattern
{
    /// <summary>
    /// 烤鱼命令,调用Receiver的烤鱼方法
    /// </summary>
    public sealed class FishCommand : Command
    {
        public FishCommand(Chef chef)
            : base(chef)
        { }

        public override void Excute()
        {
            Chef.CookFish();
        }
    }
}