using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactoryPattern
{
    /// <summary>
    /// 简单工厂模式客户端实现
    /// </summary>
    public class SimpleFactoryPatternClient
    {
        public void Main()
        {
            Operation operation;
            operation = OperationFactory.CreateOperation("+");
            operation.NumberA = 10;
            operation.NumberB = 20;
            double result = operation.GetResult();

            Console.WriteLine("简单工厂模式测试示例：{0}+{1}={2}", 10, 20, result);
        }
    }
}
