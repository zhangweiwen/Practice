namespace CommandPattern
{
    /// <summary>
    /// 命令模式,目的是想调用Receiver的方法,但不能直接调.
    /// 每个Receiver的方法的方法定义一个命令
    /// 把命令发给Invoker的方式去执行方法
    /// </summary>
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var chef = new Chef();
            var waiter = new Waiter();
            var fishCommand = new FishCommand(chef);
            var chickenCommand = new ChickenCommand(chef);
            waiter.AddOrder(fishCommand);
            waiter.AddOrder(chickenCommand);
            waiter.Finish();
        }
    }
}