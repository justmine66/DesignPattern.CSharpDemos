using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2
{
    /// <summary>
    /// 打折收费子类
    /// </summary>
    public class CashRebate : CashSuper
    {
        public CashRebate(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }

        //折扣率
        readonly double moneyRebate = 1d;

        /// <summary>
        /// 打折收费
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money * this.moneyRebate;
        }
    }
}
