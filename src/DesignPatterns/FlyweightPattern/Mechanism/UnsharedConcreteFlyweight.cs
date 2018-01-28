using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.Mechanism
{
    /// <summary>
    /// 不需要共享的子类。因为Flyweight接口共享成为可能，但它不强制共享。
    /// </summary>
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享具体的Flyweight：" + extrinsicstate);
        }
    }
}
