using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2
{
    /// <summary>
    /// 现金收费对象层超类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 收取现金
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns>当前价</returns>
        public abstract double AcceptCash(double money);
    }
}
