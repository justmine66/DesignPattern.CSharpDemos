using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern.Mechanism
{
    /// <summary>
    /// 实际的创建者
    /// </summary>
    public class ConcreteCreator : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProduct();
        }
    }
}
