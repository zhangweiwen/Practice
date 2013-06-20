namespace State
{
    /// <summary>
    /// 状态模式,状态是为Context服务的(这里是WebSite)
    /// 目的是Context做一个操作,Context里的状态跟着改变
    /// </summary>
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var site = new WebSite();
            site.TryOpenAdmin();
            site.Login("zhang", "weiwen");
            site.Login("admin", "123456");
            site.TryOpenAdmin();
            site.Logout();
            site.TryOpenAdmin();
        }
    }
}