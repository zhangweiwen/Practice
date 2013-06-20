using System;

namespace IteratorPattern
{
    /// <summary>
    /// 迭代器模式
    /// 没有用的模式
    /// </summary>
    class Program
    {
        static void Main()
        {
            var newsCollect = new NewsCollect();
            newsCollect[0] = new NewsCollect { Content = "a" };
            newsCollect[1] = new NewsCollect { Content = "b" };
            newsCollect[2] = new NewsCollect { Content = "c" };
            newsCollect[3] = new NewsCollect { Content = "d" };
            newsCollect[4] = new NewsCollect { Content = "e" };
            while (newsCollect.IsDone() == false)
            {
                Console.WriteLine(newsCollect.Current().Content);
                newsCollect.Next();
            }
        }
    }
}