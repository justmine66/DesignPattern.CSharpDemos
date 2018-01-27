using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Mechanism
{
    public class ConcreteImplementorB : ImplementorBase
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现者B的方法.");
        }
    }
}
