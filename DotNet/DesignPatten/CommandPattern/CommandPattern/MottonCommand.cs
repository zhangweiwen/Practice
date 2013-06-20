namespace CommandPattern
{
    /// <summary>
    /// 烤羊命令,调用Receiver的烤羊方法
    /// </summary>
    public sealed class MottonCommand : Command
    {
        public MottonCommand(Chef chef)
            : base(chef)
        {
        }

        public override void Excute()
        {
            Chef.CookMotton();
        }
    }
}