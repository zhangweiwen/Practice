using System;

namespace Factory
{

    /*
     *实现一个加减乘除计算器
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            const string calc = "*";
            const string format = "{0} {1} {2} => {3}";
            var oper = OperationFactory.CreateOperation(calc);
            oper.X = 5;
            oper.Y = 9;
            var result = oper.GetResult();
            Console.WriteLine(format, oper.X, calc, oper.Y, result);
        }
    }
}