using System;

namespace Composite
{
    public sealed class Button : Control
    {
        public override void AddChild(Control control)
        {
            Console.WriteLine("Button控件不能添加子控件!");
        }

        public override void Remove(Control control)
        {
            Console.WriteLine("Button控件不能移除子控件!");
        }
    }
}