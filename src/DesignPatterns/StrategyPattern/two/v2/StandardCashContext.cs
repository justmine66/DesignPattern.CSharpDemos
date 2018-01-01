using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.two.v2
{
    public class StandardCashContext
    {
        /// <summary>
        /// 初始化 CashContext
        /// 通过构造函数传入具体的收费策略
        /// </summary>
        /// <param name="cashSuper"></param>
        public StandardCashContext(CashSuper cashSuper)
        {
            this.cashSuper = cashSuper;
        }

        readonly CashSuper cashSuper;

        public double GetResult(double money)
        {
            return this.cashSuper.AcceptCash(money);
        }
    }
}
