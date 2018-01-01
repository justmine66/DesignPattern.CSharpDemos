using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2.Mechanism
{
    /// <summary>
    /// 策略机制测试类
    /// </summary>
    public class StrategyMechanismTest
    {
        public void Main()
        {
            //由于实例化不同的策略，所以最终在调用 context.ContextInterface() 获得结果不尽相同
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }
}
