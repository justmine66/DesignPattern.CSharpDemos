using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Mechanism
{
    /// <summary>
    /// 具体的装饰对象B，起到给Component添加职责的功能
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        /// <summary>
        /// 首先允许Component的Operation()，在执行本类的功能，如AddedBehavior()，相当于对Component进行了装饰
        /// </summary>
        public override void Operation()
        {
            base.Operation();

            this.AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        public void AddedBehavior()
        {

        }
    }
}
