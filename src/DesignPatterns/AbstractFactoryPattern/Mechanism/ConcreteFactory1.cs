using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.Mechanism
{
    /// <summary>
    /// 具体的工厂，创建具有特定实现的产品对象
    /// </summary>
    public class ConcreteFactory1 : IAbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
