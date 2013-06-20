using System;

namespace MediatorPattern
{
    /// <summary>
    /// 用户发送消息是通过中介者来发送的
    /// </summary>
    public sealed class QQUser
    {
        public string No { get; set; }

        public string Name { get; set; }

        public void Send(QQUser to, string msg)
        {
            if (to == null)
                throw new ArgumentNullException("to");

            if (msg == null)
                throw new ArgumentNullException("msg");

            const string format = "{2}发给'{0}'一条消息:{1}";
            Console.WriteLine(format, to.Name, msg, Name);
            QQChat.Instance.Send(this, to, msg);
        }

        public void Receive(QQUser from, string msg)
        {
            const string format = "{2}收到来自'{0}'的消息:{1}";
            Console.WriteLine(format, from.Name, msg, Name);
        }
    }
}