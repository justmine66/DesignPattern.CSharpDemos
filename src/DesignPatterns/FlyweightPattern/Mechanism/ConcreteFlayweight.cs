using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.Mechanism
{
    /// <summary>
    /// 为内部状态增加存储空间
    /// </summary>
    public class ConcreteFlayweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体的Flyweight：" + extrinsicstate);
        }
    }
}
