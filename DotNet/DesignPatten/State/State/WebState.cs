namespace State
{
    /// <summary>
    /// 状态抽象类
    /// 抽象方法的定义一般对应Context的操作方法
    /// </summary>
    public abstract class WebState
    {
        /// <summary>
        /// 授权
        /// </summary>
        /// <param name="webSite"></param>
        public abstract void Authenticate(WebSite webSite);

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="webSite"></param>
        public abstract void Logout(WebSite webSite);
    }
}