using System;
using System.Collections.Generic;

namespace CommandPattern
{
    /// <summary>
    /// Invoker,管理命令的地方
    /// </summary>
    public sealed class Waiter
    {
        private readonly List<Command> _orders = new List<Command>();

        public void AddOrder(Command command)
        {
            if (command == null)
                return;

            Console.WriteLine("想点: {0}", command);

            if (command is ChickenCommand)
            {
                Console.WriteLine("服务员:抱歉!烤鸡卖光了!");
                return;
            }
            _orders.Add(command);
            Console.WriteLine("'{0}'下单成功!", command);
        }

        public void CancelOrder(Command command)
        {
            if (command == null)
                return;

            _orders.Remove(command);
            Console.WriteLine("取消: {0}", command);
        }

        public void Finish()
        {
            foreach (var order in _orders)
            {
                order.Excute();
            }
        }
    }
}