using System;

namespace Factory
{
    /// <summary>
    /// 创建计算器的工厂类,工厂模式主要用于创建
    /// 返回一个基类或者接口
    /// </summary>
    public class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            switch (operate)
            {
                case "+":
                    return new OperationAdd();
                case "-":
                    return new OperationSub();
                case "*":
                    return new OperationMul();
                case "/":
                    return new OperationDiv();
                default:
                    throw new NotSupportedException("不支持其它计算!");
            }
        }
    }
}