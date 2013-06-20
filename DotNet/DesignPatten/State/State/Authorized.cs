using System;

namespace State
{
    /// <summary>
    /// 以授权状态
    /// 这里对应的操作去改变对应的状态即可
    /// </summary>
    public sealed class Authorized : WebState
    {
        public override void Authenticate(WebSite webSite)
        {
            //这里设计为不允许重复授权
            //Console.WriteLine("重复授权!");
            throw new InvalidOperationException("重复授权!");
        }

        public override void Logout(WebSite webSite)
        {
            webSite.State = new UnAuthorized();
            Console.WriteLine("退出成功!");
        }
    }
}