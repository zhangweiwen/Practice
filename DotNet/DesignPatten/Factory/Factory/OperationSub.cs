namespace Factory
{
    public sealed class OperationSub : Operation
    {
        public override double GetResult()
        {
            return X - Y;
        }
    }
}