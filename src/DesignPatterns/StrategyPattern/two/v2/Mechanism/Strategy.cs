using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2.Mechanism
{
    /// <summary>
    /// 抽象算法类
    /// 定义所有支持的算法的公共接口
    /// </summary>
    public abstract class Strategy
    {
        /// <summary>
        /// 算法方法
        /// </summary>
        public abstract void AlgorithmInterface();
    }
}
