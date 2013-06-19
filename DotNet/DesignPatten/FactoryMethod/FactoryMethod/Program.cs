using System;
using System.Reflection;

namespace FactoryMethod
{
    /// <summary>
    /// 工厂方法模式,连工厂也抽象出来
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var factory = assembly.CreateInstance("FactoryMethod." + Sys.Default.FactoryName) as LogFactory;
            if (factory == null)
                throw new InvalidOperationException("Create LogFactory instance failed.");

            var log = factory.Create();
            log.Info("test!");
        }
    }
}