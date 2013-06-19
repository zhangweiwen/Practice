namespace TemplateMethod
{
    /// <summary>
    /// 模版方法模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var userDataAccess = new UserInfoDataAccess();
            userDataAccess.Run();
        }
    }
}