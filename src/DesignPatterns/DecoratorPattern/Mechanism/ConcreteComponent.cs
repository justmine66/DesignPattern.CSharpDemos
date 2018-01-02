using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Mechanism
{
    /// <summary>
    /// 定义一个具体的对象，也可以给这些对象添加职责
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}
