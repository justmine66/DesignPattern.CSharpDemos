using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.Mechanism
{
    /// <summary>
    /// 抽象工厂接口，里面包含所有的产品创建的抽象方法
    /// </summary>
    public interface IAbstractFactory
    {
        AbstractProductA CreateProductA();
        AbstractProductB CreateProductB();
    }
}
