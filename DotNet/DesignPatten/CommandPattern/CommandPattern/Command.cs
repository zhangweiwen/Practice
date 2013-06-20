using System;

namespace CommandPattern
{
    /// <summary>
    /// 命令抽象,传入一个Receiver类进来
    /// 子类是什么命令就调用Receiver类的什么方法
    /// </summary>
    public abstract class Command
    {
        protected Chef Chef;

        protected Command(Chef chef)
        {
            if (chef == null)
                throw new ArgumentNullException("chef");

            Chef = chef;
        }

        public abstract void Excute();
    }
}