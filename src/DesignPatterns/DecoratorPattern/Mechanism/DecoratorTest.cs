using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Mechanism
{
    public class DecoratorTest
    {
        public void Main()
        {
            var concreteComponent = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            d1.SetComponent(concreteComponent);
            d2.SetComponent(d1);

            d2.Operation();
        }
    }
}
