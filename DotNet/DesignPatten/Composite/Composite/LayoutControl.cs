using System;
using System.Collections.Generic;

namespace Composite
{
    public sealed class LayoutControl : Control
    {
        //子节点的容器（可以是叶节点，叶可以是下一节主干）
        private readonly List<Control> _children = new List<Control>();

        public override void AddChild(Control control)
        {
            if (control != null)
                _children.Add(control);
        }

        public override void Remove(Control control)
        {
            if (control != null)
                _children.Remove(control);
        }

        public override void Show(int depth = 1)
        {
            var pad = new string('-', depth);
            Console.WriteLine(pad + "Name: " + Name);
            if (_children.Count == 0)
                return;

            depth = depth + 1;
            Console.WriteLine(pad + "Children:");
            foreach (var child in _children)
            {
                child.Show(depth);
            }
        }
    }
}