using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern.Mechanism
{
    /// <summary>
    /// 定义一个创建对象的接口
    /// </summary>
    public interface ICreator
    {
        IProduct CreateProduct();
    }
}
