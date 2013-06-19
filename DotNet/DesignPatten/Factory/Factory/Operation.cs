namespace Factory
{
    /// <summary>
    /// 抽象计算类
    /// </summary>
    public abstract class Operation
    {
        public double X { get; set; }
        public double Y { get; set; }

        public abstract double GetResult();
    }
}