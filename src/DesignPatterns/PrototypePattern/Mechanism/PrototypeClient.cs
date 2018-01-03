using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypePattern.Mechanism
{
    /// <summary>
    /// 原型模式客户端实现
    /// </summary>
    public class PrototypePatternClient
    {
        public void Main()
        {
            var concretePrototypeA = new ConcretePrototypeA("a");
            var concretePrototypeACopy = concretePrototypeA.Clone();
            Console.WriteLine("自己:{0}", concretePrototypeA.ID);
            Console.WriteLine("副本:{0}", concretePrototypeACopy.ID);
        }
    }
}
