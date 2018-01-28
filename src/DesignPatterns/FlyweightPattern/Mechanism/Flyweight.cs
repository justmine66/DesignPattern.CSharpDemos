using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.Mechanism
{
    /// <summary>
    /// 它是所有享元类的超类或接口，通过这个接口，Flyweight可以接受并作用于外部状态
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
