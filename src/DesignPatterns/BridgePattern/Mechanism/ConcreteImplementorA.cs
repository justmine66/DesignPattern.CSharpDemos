using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Mechanism
{
    /// <summary>
    /// 具体实现者A
    /// </summary>
    public class ConcreteImplementorA : ImplementorBase
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现者A的方法.");
        }
    }
}
