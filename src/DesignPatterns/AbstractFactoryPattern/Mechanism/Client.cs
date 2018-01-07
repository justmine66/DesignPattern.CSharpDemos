using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.Mechanism
{
    /// <summary>
    /// 客户端
    /// </summary>
    public class Client
    {
        public void Main()
        {
            IAbstractFactory abstractFactory1 = new ConcreteFactory1();
            AbstractProductA abstractProductA1 = abstractFactory1.CreateProductA();
            AbstractProductB abstractProductB1 = abstractFactory1.CreateProductB();

            IAbstractFactory abstractFactory2 = new ConcreteFactory2();
            AbstractProductA abstractProductA2 = abstractFactory2.CreateProductA();
            AbstractProductB abstractProductB2 = abstractFactory2.CreateProductB();
        }
    }
}
