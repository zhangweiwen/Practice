using System;

namespace Composite
{
    public abstract class Control
    {
        public string Name { get; set; }

        public abstract void AddChild(Control control);

        public abstract void Remove(Control control);

        public virtual void Show(int depth = 1)
        {
            Console.WriteLine(new string('-', depth) + "Name: " + Name);
        }
    }
}