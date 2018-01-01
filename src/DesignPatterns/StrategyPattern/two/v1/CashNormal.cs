using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v1
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    public class CashNormal : CashSuper
    {
        /// <summary>
        /// 正常收费，返回原价
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
