namespace Factory
{
    public sealed class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return X + Y;
        }
    }
}