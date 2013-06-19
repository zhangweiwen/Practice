using System;
using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// 产品类,定义好产品的结构,可以是一堆公共属性,也可以像下面这样
    /// 关键在于对属性的赋值(对Add方法的调用)由专门的Builder类去负责,而不是由客户端去赋值
    /// </summary>
    public sealed class Car
    {
        private readonly string _name;
        private readonly double _price;
        private readonly List<string> _parts = new List<string>();

        public Car(string name, double price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(name);

            if (price <= 0)
                throw new ArgumentException("价钱不能少于0!", "price");

            _name = name;
            _price = price;
        }

        public void Add(string part)
        {
            if (string.IsNullOrWhiteSpace(part) == false)
                _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("名称 => " + _name);
            Console.WriteLine("价格 => " + _price);
            Console.WriteLine("配置如下:");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}