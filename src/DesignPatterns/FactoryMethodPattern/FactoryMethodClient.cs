using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern
{
    /// <summary>
    /// 工厂方法模式客户端实现
    /// </summary>
    public class FactoryMethodClient
    {
        public void Main()
        {
            IFactory oprFactory = new AddFactory();
            Operation operation = oprFactory.CreateOperation();
            operation.NumberA = 10;
            operation.NumberB = 10;
            double result = operation.GetResult();
        }
    }
}
