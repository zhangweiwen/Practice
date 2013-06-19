namespace FactoryMethod
{
    public class EventLogFactory : LogFactory
    {
        public override Log Create()
        {
            return new EventLog();
        }
    }
}