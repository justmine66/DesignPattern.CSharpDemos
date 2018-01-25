using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.Mechanism
{
    /// <summary>
    /// 叶节点对象
    /// 由于叶节点不能添加分枝和树叶的能力，所有Add和Remove方法实现它没意义，但这样可以消除叶节点和枝节点在对象抽象层次上的区别，它们具有完全一致的接口。
    /// </summary>
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf.");
        }

        /// <summary>
        /// 叶节点的具体方法，此处显示名称和深度
        /// </summary>
        /// <param name="depth"></param>
        public override void Display(int depth)
        {
            Console.WriteLine(string.Format("{0} {1}", new string('-', depth), this.Name));
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf.");
        }
    }
}
