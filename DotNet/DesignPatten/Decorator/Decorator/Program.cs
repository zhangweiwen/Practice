namespace Decorator
{
    public class Program
    {
        /*
         * 使用装饰貌似实现类似Asp.Net mvc的简单的AOP
        */
        public static void Main(string[] args)
        {
            var home = new HomeController();
            //装饰过程
            var executed = new ActionExecuted(home);
            var executing = new ActionExecuting(executed);

            executing.Action();

        }
    }
}