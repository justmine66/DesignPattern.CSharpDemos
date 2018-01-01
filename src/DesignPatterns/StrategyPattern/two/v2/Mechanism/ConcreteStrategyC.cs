using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2.Mechanism
{
    /// <summary>
    /// 具体算法C
    /// </summary>
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }
}
