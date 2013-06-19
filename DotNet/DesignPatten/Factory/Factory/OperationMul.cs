namespace Factory
{
    public sealed class OperationMul : Operation
    {
        public override double GetResult()
        {
            return X * Y;
        }
    }
}