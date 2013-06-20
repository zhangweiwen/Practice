using System;

namespace State
{
    /// <summary>
    /// Context类,状态是为这个类服务的
    /// </summary>
    public sealed class WebSite
    {
        public const string AdminUserName = "admin";
        public const string AdminPassword = "123456";

        public WebState State { get; set; }

        public WebSite()
        {
            State = new UnAuthorized();
        }

        public void TryOpenAdmin()
        {
            Console.WriteLine("尝试访问后台管理页面!");
            if (State is Authorized)
            {
                Console.WriteLine("成功打开后台管理页面!");
            }
            else
            {
                Console.WriteLine("未授权!请先登录!");                
            }
        }

        public void Login(string userName, string password)
        {
            try
            {
                if (userName == AdminUserName && password == AdminPassword)
                {
                    State.Authenticate(this);
                    return;
                }
                Console.WriteLine("用户名或密码错误!");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Logout()
        {
            State.Logout(this);
        }
    }
}