using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.Mechanism
{
    /// <summary>
    /// 为组合中的对象声明接口
    /// </summary>
    public abstract class Component
    {
        protected string Name;

        public Component(string name)
        {
            this.Name = name;
        }

        //通过使用Add和Remove方法来提供增加或移除树叶和树枝的功能
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
