using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2.Mechanism
{
    /// <summary>
    /// 具体算法A
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
}
