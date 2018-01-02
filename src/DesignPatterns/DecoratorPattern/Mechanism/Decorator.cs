using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Mechanism
{
    /// <summary>
    /// 装饰抽象类
    /// 继承Component，从外类来扩展Component的功能，但对于Component来说，无需知道Decorator的存在的
    /// </summary>
    public abstract class Decorator : Component
    {
        Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
