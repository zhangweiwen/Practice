using System;

namespace CommandPattern
{
    /// <summary>
    /// 厨师
    /// Receive
    /// 这个有什么能力,就定义什么命令
    /// 目的是不直接调用里的方法,通过Add对应的命令来调用这里的方法
    /// </summary>
    public class Chef
    {
        public void CookFish()
        {
            Console.WriteLine("烤了一条鱼!");
        }

        public void CookChicken()
        {
            Console.WriteLine("烤了一只鸡!");
        }

        public void CookMotton()
        {
            Console.WriteLine("烤了一只羊!");
        }
    }
}