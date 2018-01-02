using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Mechanism
{
    /// <summary>
    /// 定义一个对象接口
    /// 可以给这些对象动态的添加职责
    /// </summary>
    public abstract class Component
    {
        public abstract void Operation();
    }
}
