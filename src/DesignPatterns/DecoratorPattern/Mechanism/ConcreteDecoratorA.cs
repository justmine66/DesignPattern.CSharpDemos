using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Mechanism
{
    /// <summary>
    /// 具体的装饰对象A，起到给Component添加职责的功能
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        string addedState;

        /// <summary>
        /// 首先允许Component的Operation()，在执行本类的功能，如addedState，相当于对Component进行了装饰
        /// </summary>
        public override void Operation()
        {
            base.Operation();

            this.addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}
