using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2.Mechanism
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        readonly Strategy strategy;

        /// <summary>
        /// 根据具体的策略对象，调用其算法的方法
        /// </summary>
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
