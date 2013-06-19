using System;

namespace Builder
{
    /// <summary>
    /// 建造者模式,目的是目的是使用几个类去new一个产品类,直接在客户端new就是输,这个需求跟工厂模式类似
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var qqBuilder = new QQCarBuilder();
            var cayenneBuilder = new CayenneBuilder();

            director.Construct(qqBuilder);
            director.Construct(cayenneBuilder);

            var qq = qqBuilder.GetCar();
            var cayenne = cayenneBuilder.GetCar();

            qq.Show();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            cayenne.Show();
        }
    }
}