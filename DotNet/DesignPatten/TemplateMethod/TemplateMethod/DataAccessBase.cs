using System;

namespace TemplateMethod
{
    public abstract class DataAccessBase<T>
    {
        protected abstract T[] QueryData();

        protected abstract void DisplayData(T[] datas);

        protected virtual void Connect()
        {
            Console.WriteLine("打开192.168.1.100的Sql Server 2008的Test数据库连接!");
        }

        protected virtual void Disconnect()
        {
            Console.WriteLine("断开192.168.1.100的Sql Server 2008的Test数据库连接!");
        }

        /// <summary>
        /// 这个就是模版方法,某些子方法的实际逻辑可以在子类实现
        /// </summary>
        public void Run()
        {
            Connect();
            var data = QueryData();
            DisplayData(data);
            Disconnect();
        }
    }
}