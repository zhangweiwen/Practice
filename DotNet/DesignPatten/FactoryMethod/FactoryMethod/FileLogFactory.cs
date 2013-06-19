namespace FactoryMethod
{
    public sealed class FileLogFactory : LogFactory
    {
        public override Log Create()
        {
            return new FileLog();
        }
    }
}
