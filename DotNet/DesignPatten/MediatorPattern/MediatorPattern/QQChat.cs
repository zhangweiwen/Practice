using System;
using System.Collections.Generic;
using System.Linq;

namespace MediatorPattern
{
    /// <summary>
    /// QQ聊天工具(中介者)
    /// Mediator
    /// </summary>
    public sealed class QQChat
    {
        private static readonly Lazy<QQChat> InstanceLazy = new Lazy<QQChat>(true);

        /// <summary>
        /// 已注册用户
        /// </summary>
        private readonly List<QQUser> _users = new List<QQUser>
        {
            new QQUser {Name = "刘备", No = "001"},
            new QQUser {Name = "关羽", No = "002"},
            new QQUser {Name = "张飞", No = "003"},
            new QQUser {Name = "赵云", No = "004"},
        };

        public static QQChat Instance
        {
            get { return InstanceLazy.Value; }
        }

        public QQUser Login(string no)
        {
            return _users.FirstOrDefault(u => u.No == no);
        }

        public void Send(QQUser form, QQUser to, string msg)
        {
            to.Receive(form, msg);
        }
    }
}