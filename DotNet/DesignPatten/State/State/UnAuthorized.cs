using System;

namespace State
{
    /// <summary>
    /// 未授权状态
    /// 这里对应的操作去改变对应的状态即可
    /// </summary>
    public sealed class UnAuthorized : WebState
    {
        public override void Authenticate(WebSite webSite)
        {
            webSite.State = new Authorized();
            Console.WriteLine("授权成功!");
        }

        public override void Logout(WebSite webSite)
        {
            webSite.State = this;
            Console.WriteLine("这是本来就没有授权的退出!");
        }
    }
}