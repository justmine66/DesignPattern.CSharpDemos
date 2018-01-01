using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2.Mechanism
{
    /// <summary>
    /// 具体算法B
    /// </summary>
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
}
