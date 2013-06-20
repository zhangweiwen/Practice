namespace Composite
{
    /// <summary>
    /// 组合模式,最典型的就是控件添加子控件的问题
    /// Layout控件就是树枝,可以添加子控件
    /// 不能添加子控件的就是树叶
    /// </summary>
    public sealed class Program
    {
        static void Main()
        {
            var root = new LayoutControl { Name = "根" };
            var left = new LayoutControl { Name = "左边导航栏" };
            root.AddChild(left);
            root.AddChild(new LayoutControl { Name = "顶部Banner" });
            root.AddChild(new LayoutControl { Name = "主区域" });
            left.AddChild(new Button { Name = "菜单1" });
            left.AddChild(new Button { Name = "菜单2" });
            left.AddChild(new Button { Name = "菜单3" });

            root.Show();
        }
    }
}