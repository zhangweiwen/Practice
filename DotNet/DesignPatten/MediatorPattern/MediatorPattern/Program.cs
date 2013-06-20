namespace MediatorPattern
{
    /// <summary>
    /// 中介者模式,发送消息不是直接发给目标,而是通过中介者发送
    /// </summary>
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var zhang = QQChat.Instance.Login("003");
            var zhao = QQChat.Instance.Login("004");

            zhang.Send(zhao, "最近研究什么技术啊?");
            zhao.Send(zhang, "javascript啊,火了!");
        }
    }
}