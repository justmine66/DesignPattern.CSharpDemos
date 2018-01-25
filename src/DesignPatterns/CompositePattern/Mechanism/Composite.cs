using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.Mechanism
{
    /// <summary>
    /// 定义直接点行为，用来存储子部件，在Composite中实现与子部件相关的操作
    /// </summary>
    public class Composite : Component
    {
        private IList<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(string.Format("{0} {1}", new string('-', depth), this.Name));

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }
    }
}
